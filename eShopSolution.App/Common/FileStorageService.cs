using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Threading.Tasks;

namespace eShopSolution.App.Common
{
    public class FileStorageService : IStorageService
    {
        private readonly string _userContentFolder;
        private const string STORE_CONTENT_FOLDER_NAME = "/eShopSolution/wwwroot/themes/images/user_content";
        private const string OUTPUT_CONTENT_FOLDER_NAME = "/themes/images/user_content";

        //private const string USER_CONTENT_FOLDER_NAME = "user-content";
        private readonly IConfiguration _configuration;

        public FileStorageService(IWebHostEnvironment webHostEnvironment, IConfiguration configuration)
        {
            var projectDirectory = Path.GetFullPath(Path.GetDirectoryName(Path.GetDirectoryName(webHostEnvironment.WebRootPath)));
            var storeFolder = STORE_CONTENT_FOLDER_NAME.Replace("/", "\\");
            _userContentFolder = projectDirectory + storeFolder;
            //_userContentFolder = Path.Combine(webHostEnvironment.WebRootPath, USER_CONTENT_FOLDER_NAME);
            _configuration = configuration;
        }

        public string GetFileUrl(string fileName)
        {
            return $"{OUTPUT_CONTENT_FOLDER_NAME}/{fileName}";
        }

        public async Task<string> SaveFileAsync(Stream mediaBinaryStream, string fileName)
        {
            var filePath = Path.Combine(_userContentFolder, fileName);
            using var output = new FileStream(filePath, FileMode.Create);
            await mediaBinaryStream.CopyToAsync(output);
            return GetFileUrl(fileName);
        }

        public async Task DeleteFileAsync(string fileName)
        {
            var filePath = Path.Combine(_userContentFolder, fileName);
            if (File.Exists(filePath))
            {
                await Task.Run(() => File.Delete(filePath));
            }
        }
    }
}