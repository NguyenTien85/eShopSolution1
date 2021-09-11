﻿namespace eShopSolution.ViewModels.Common
{
    public class ApiErrorResult<T> : ApiResult<T>
    {
        public string[] ValidationErrors { get; set; }

        public ApiErrorResult(string message)
        {
            IsSucceeded = false;
            Message = message;
        }

        public ApiErrorResult(string[] validationErrors)
        {
            IsSucceeded = false;
            ValidationErrors = validationErrors;
        }
    }
}