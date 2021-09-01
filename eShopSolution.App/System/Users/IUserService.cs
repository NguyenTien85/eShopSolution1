﻿using eShopSolution.ViewModels.Common;
using eShopSolution.ViewModels.System.Users;
using eShopSolution.ViewModels.System.Users.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.App.System.Users
{
    public interface IUserService
    {
        Task<string> Authenticate(LoginRequest request);

        Task<bool> Register(RegisterRequest request);

        Task<PagedResult<UserViewModel>> GetUserPaging(GetUserPagingRequest request);
    }
}