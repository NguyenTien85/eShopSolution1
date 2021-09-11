﻿using eShopSolution.ViewModels.Catalog.Categories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.ApiIntegration
{
    public interface ICategoryApiClient
    {
        Task<List<CategoryViewModel>> GetAll(string languageId);

        Task<CategoryViewModel> GetById(int id, string languageId);
    }
}