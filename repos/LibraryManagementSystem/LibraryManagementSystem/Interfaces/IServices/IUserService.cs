using LibraryManagementSystem.Dtos;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Interfaces.IServices
{
    public interface IUserService
    {
        public Task<UserResponseModel> GetUser(int id);
        public Task<UsersResponseModel> GetUsers();
        public Task<BaseResponse> UpdateUser(int id, UpdateUserStatusRequestModel model);
        public Task<BaseResponse> UpgradeUser(int id, UpgradeLibraryUserRequestModel model);
        public Task<BaseResponse> AddUser(CreateUserRequestModel model);
        public Task<BaseResponse> DeleteUser(int id);
    }
}
