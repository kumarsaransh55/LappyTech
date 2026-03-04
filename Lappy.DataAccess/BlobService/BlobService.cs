using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lappy.DataAccess.BlobService
{
    public class BlobService : IBlobService
    {
        private readonly string _connectionString;

        public BlobService(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("AzureStorage");
        }

        public async Task<string> UploadBlob(IFormFile file, string containerName, string fileName, string folderName)
        {
            BlobServiceClient blobServiceClient = new BlobServiceClient(_connectionString);
            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);
            await containerClient.CreateIfNotExistsAsync(PublicAccessType.Blob);

            // This creates the "Folder" structure: container/folderName/fileName
            string blobPath = $"{folderName}/{fileName}";
            BlobClient blobClient = containerClient.GetBlobClient(blobPath);

            var httpHeaders = new BlobHttpHeaders { ContentType = file.ContentType };
            using (var stream = file.OpenReadStream())
            {
                await blobClient.UploadAsync(stream, httpHeaders);
            }

            return blobClient.Uri.ToString();
        }

        public async Task<bool> DeleteBlob(string blobUrl, string containerName)
        {
            Uri uri = new Uri(blobUrl);
            // This extracts the path after the container name (e.g., "15/guid.jpg")
            string blobName = uri.AbsolutePath.Substring(uri.AbsolutePath.IndexOf(containerName) + containerName.Length + 1);

            BlobServiceClient blobServiceClient = new BlobServiceClient(_connectionString);
            BlobContainerClient containerClient = blobServiceClient.GetBlobContainerClient(containerName);
            BlobClient blobClient = containerClient.GetBlobClient(blobName);

            return await blobClient.DeleteIfExistsAsync();
        }
    }
}
