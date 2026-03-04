using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lappy.DataAccess.BlobService
{
    public interface IBlobService
    {
            Task<string> UploadBlob(IFormFile file, string containerName, string fileName, string folderName);
            Task<bool> DeleteBlob(string blobUrl, string containerName);
    }
}
