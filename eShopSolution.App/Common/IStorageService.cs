﻿using System.IO;
using System.Threading.Tasks;

namespace eShopSolution.App.Common
{
    public interface IStorageService
    {
        string GetFileUrl(string fileName);

        Task<string> SaveFileAsync(Stream mediaBinaryStream, string fileName);

        Task DeleteFileAsync(string fileName);
    }
}