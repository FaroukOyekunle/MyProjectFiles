using LibraryManagementSystem.Dtos;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static LibraryManagementSystem.Models.RoleViewModel;

namespace LibraryManagementSystem.Interfaces.IServices
{
   public interface IRoleService
   {
        public Task<RoleResponseModel> GetRole(int id);
        public Task<RolesResponseModel> GetRoles();
        public Task<BaseResponse> UpdateRole(int id, UpdateRoleRequestModel model);
        public Task<BaseResponse> AddRole(CreateRoleRequestModel model);
        public Task<BaseResponse> DeleteRole(int id);
   }
}
