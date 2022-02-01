using LibraryManagementSystem.Dtos;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Enums;
using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Interfaces.Identity;
using LibraryManagementSystem.Interfaces.IRepositories;
using LibraryManagementSystem.Interfaces.IServices;
using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Implementations.Services
{
    public class UserService: IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IIdentityService _identityService;

        public UserService(IUserRepository userRePository, IIdentityService identityService)
        {
            _userRepository = userRePository;
            _identityService = identityService;
        }
        public async Task<BaseResponse> AddUser(CreateUserRequestModel model)
        {
            var user = new User
            {
                FirstName = model.FirstName,
                LastName = model.LastName,
                Country = model.Country,
                PhoneNumber = model.PhoneNumber,
                Email = model.Email,
                Status = AccountStatus.ACTIVE,
                University = model.University,
                UserType = model.UserType,
                LibrarianIdentificationNumber = Guid.NewGuid().ToString(),
                LibraryIdentificationNumber = Guid.NewGuid().ToString(),

            };
            user.Password = _identityService.GetPasswordHash(model.Password);

            var roles = await _userRepository.GetSelectedRoles(model.Roles);
            foreach (var role in roles)
            {
                var userRole = new UserRole
                {
                    User = user,
                    UserId = user.Id,
                    Role = role,
                    RoleId = role.Id

                };

                user.UserRoles.Add(userRole);
            }

            await _userRepository.AddAsync(user);
            await _userRepository.SaveChangesAsync();

            return new BaseResponse
            {
                Status = true,
                Message = "User added successfully"
            };

        }

        public async Task<BaseResponse> DeleteUser(int id)
        {
            var user = await _userRepository.GetAsync(id);

            await _userRepository.DeleteAsync(user);
            await _userRepository.SaveChangesAsync();

            return new BaseResponse
            {
                Status = true,
                Message = "User deleted successfully"
            };
        }

        public async Task<UserResponseModel> GetUser(int id)
        {
            var user = await _userRepository.Query().Include(u => u.UserRoles)
                .ThenInclude(ur => ur.Role)
                .SingleOrDefaultAsync(u => u.Id == id);

            return new UserResponseModel
            {
                Data = new UserDto
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Country = user.Country,
                    University = user.University,
                    LibrarianIdentificationNumber = user.LibrarianIdentificationNumber,
                    LibraryIdentificationNumber = user.LibraryIdentificationNumber,
                    PhoneNumber = user.PhoneNumber,
                    Status = user.Status,
                    Password = user.Password,
                    UserType = user.UserType,
                    Roles = user.UserRoles.Select(r => new RoleDto
                    {
                        Id = r.Id,
                        Description = r.Role.Description,
                        Name = r.Role.Name

                    }),

                },
                Status = true,
                Message = "User retrieved Successfully"

            };
        }

        public Task<UsersResponseModel> GetUsers()
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse> UpdateUser(int id, UpdateUserStatusRequestModel model)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse> UpgradeUser(int id, UpgradeLibraryUserRequestModel model)
        {
            throw new NotImplementedException();
        }
    }
}

