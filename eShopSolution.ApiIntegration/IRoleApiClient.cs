using eShopSolution.ViewModels.System.Roles;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eShopSolution.ApiIntegration
{
    public interface IRoleApiClient
    {
        Task<List<RoleViewModel>> GetAll();
    }
}