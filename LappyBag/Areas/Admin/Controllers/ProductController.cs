using System.Collections.Generic;
using Lappy.DataAccess.BlobService;
using Lappy.DataAccess.Repository;
using Lappy.DataAccess.Repository.IRepository;
using Lappy.Models;
using Lappy.Models.ViewModels;
using Lappy.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis;

namespace LappyBag.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBlobService _blobService;
        public ProductController(IUnitOfWork unitOfWork, IBlobService blobService)
        {
            _unitOfWork = unitOfWork;
            _blobService = blobService;
        }
        public IActionResult Index()
        {
            IEnumerable<Product> obj = _unitOfWork.Product.GetAll(includeProperties: "Category").ToList();
            return View(obj);
        }
        public IActionResult Upsert(int? id)
        {
            IEnumerable<SelectListItem> categoryList = _unitOfWork.Category.GetAll().Select(u => new SelectListItem { Text = u.Name, Value = u.Id.ToString() });
            //ViewBag.categoryListVb=categoryList;
            // We can also transfer data from controller to view which is not present in the model itself by using viewdata(Little hard) Like by
            // ViewData["categoryList"] and using in view by casting it as asp-items="@(ViewData[categoryList] as IEnumerable<SelectListItem>)"
            Product product = new Product();
            if (id != null && id != 0)
            {
                product = _unitOfWork.Product.Get(u => u.Id == id, includeProperties: "ProductImages");
            }
            ProductVM productvM = new ProductVM()
            {
                CategoryListVb = categoryList,
                Product = product
            };
            return View(productvM);
        }
        [HttpPost]
        public async Task<IActionResult> Upsert(ProductVM productVm, List<IFormFile> files)
        {
            if (files == null && productVm.Product.Id == 0)
            {
                ModelState.AddModelError("err", "Please Upload Image while Creating a Product");
            }
            if (ModelState.IsValid)
            {
                if (productVm.Product.Id == 0)
                {
                    _unitOfWork.Product.Add(productVm.Product);
                    TempData["successmsg"] = "Product Created Successfully";
                }
                else
                {
                    _unitOfWork.Product.Update(productVm.Product);
                    TempData["successmsg"] = "Product Updated Successfully";
                }
                _unitOfWork.Save();

                if (files != null && files.Count > 0)
                {
                    foreach (IFormFile file in files)
                    {
                        string fileName = Guid.NewGuid().ToString() + Path.GetExtension(file.FileName);

                        // Pass ProductId as the folderName
                        string imageUrl = await _blobService.UploadBlob(
                            file,
                            "product-images",
                            fileName,
                            productVm.Product.Id.ToString()
                        );

                        ProductImage productImage = new()
                        {
                            ImageUrl = imageUrl,
                            ProductId = productVm.Product.Id
                        };

                        _unitOfWork.ProductImage.Add(productImage);
                    }
                    _unitOfWork.Save();
                }
                return RedirectToAction("Index");
            }
            productVm.CategoryListVb = _unitOfWork.Category.GetAll().Select(u => new SelectListItem { Text = u.Name, Value = u.Id.ToString() });
            return View(productVm);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int? id)
        {
            var productToBeDeleted = _unitOfWork.Product.Get(u => u.Id == id);
            if (productToBeDeleted == null)
            {
                return Json(new { success = false, message = "Error while deleting" });
            }

            // 1. Find all images associated with this product
            var productImages = _unitOfWork.ProductImage.GetAll(u => u.ProductId == id).ToList();

            // 2. Delete each image from Azure Blob Storage
            foreach (var image in productImages)
            {
                await _blobService.DeleteBlob(image.ImageUrl, "product-images");
            }

            // 3. Delete from Database
            _unitOfWork.Product.Remove(productToBeDeleted);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete Successful" });
        }

        public async Task<IActionResult> DeleteProductImage(int? imageId)
        {
            if (imageId == null)
            {
                return NotFound();
            }
            var imageToBeDeleted = _unitOfWork.ProductImage.Get(u => u.Id == imageId);
            if (imageToBeDeleted == null)
            {
                return NotFound();
            }
            int productId = imageToBeDeleted.ProductId;
            // Delete from Azure
            await _blobService.DeleteBlob(imageToBeDeleted.ImageUrl, "product-images");

            // Delete from DB
            _unitOfWork.ProductImage.Remove(imageToBeDeleted);
            _unitOfWork.Save();

            TempData["success"] = "Image deleted successfully";

            return RedirectToAction(nameof(Upsert), new { id = productId });
        }

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Product> obj = _unitOfWork.Product.GetAll(includeProperties: "Category").ToList();
            return Json(new { data = obj });
        }
        #endregion
    }
}
