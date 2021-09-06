﻿using eShopSolution.Data.EF;
using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.System.Languages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.App.System.Languages
{
    public class LanguageService : ILanguageService
    {
        private readonly IConfiguration _config;
        private readonly eShopDbContext _context;

        public LanguageService(IConfiguration config, eShopDbContext context)
        {
            _config = config;
            _context = context;
        }

        public async Task<ApiResult<List<LanguageViewModel>>> GetAll()
        {
            var languages = await _context.Languages
                .Select(x => new LanguageViewModel()
                {
                    Id = x.Id,
                    Name = x.Name
                })
                .ToListAsync();
            return new ApiSuccessResult<List<LanguageViewModel>>(languages);
        }
    }
}