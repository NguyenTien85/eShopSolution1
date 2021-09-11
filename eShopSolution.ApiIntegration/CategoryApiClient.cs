﻿using eShopSolution.Utilities.Constants;
using eShopSolution.ViewModels.Catalog.Categories;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace eShopSolution.ApiIntegration
{
    public class CategoryApiClient : BaseApiClient, ICategoryApiClient
    {
        public CategoryApiClient(IHttpClientFactory httpClientFactory,
               IConfiguration configuration,
               IHttpContextAccessor httpContextAccessor)
               : base(httpClientFactory, configuration, httpContextAccessor)
        {
        }

        public async Task<List<CategoryViewModel>> GetAll(string languageId)
        {
            return await GetAsync<List<CategoryViewModel>>($"/api/categories?languageId={languageId}");
        }

        public async Task<CategoryViewModel> GetById(int id, string languageId)
        {
            return await GetAsync<CategoryViewModel>($"/api/categories/{id}/{languageId}");
        }
    }
}