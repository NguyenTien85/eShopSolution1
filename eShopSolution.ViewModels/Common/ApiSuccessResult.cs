using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.ViewModels.Common
{
    public class ApiSuccessResult<T> : ApiResult<T>
    {
        public ApiSuccessResult(T resultObj)
        {
            IsSucceeded = true;
            ResultObj = resultObj;
        }

        public ApiSuccessResult()
        {
            IsSucceeded = true;
        }
    }
}