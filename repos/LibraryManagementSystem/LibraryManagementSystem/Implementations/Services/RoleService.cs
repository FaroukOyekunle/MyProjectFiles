using LibraryManagementSystem.Dtos;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Interfaces;
using LibraryManagementSystem.Interfaces.IServices;
using LibraryManagementSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static LibraryManagementSystem.Models.RoleViewModel;

namespace LibraryManagementSystem.Implementations.Services
{
    public class RoleService:IRoleService
    {
        private readonly IRoleRepository _roleRepository;

        public RoleService(IRoleRepository roleRepository)
        {
            _roleRepository = roleRepository;
        }
        public async Task<BaseResponse> AddRole(CreateRoleRequestModel model)
        {
            var role = new Role
            {
                Name = model.Name,
                Description = model.Description
            };

            await _roleRepository.AddAsync(role);
            await _roleRepository.SaveChangesAsync();

            return new BaseResponse
            {
                Status = true,
                Message = "Role Added successfully"
            };


        }

        public async Task<BaseResponse> DeleteRole(int id)
        {
            var role = await _roleRepository.GetAsync(id);

            await _roleRepository.DeleteAsync(role);
            await _roleRepository.SaveChangesAsync();

            return new BaseResponse
            {
                Status = true,
                Message = "Role Deleted Successfully"
            };
        }

        public async Task<RoleResponseModel> GetRole(int id)
        {
            var role = await _roleRepository.GetAsync(id);

            return new RoleResponseModel
            {
                Data = new RoleDto
                {
                    Id = role.Id,
                    Name = role.Name,
                    Description = role.Description
                },
                Status = true,
                Message = "Role added successfully"

            };
        }

        public async Task<RolesResponseModel> GetRoles()
        {
            var roles = await _roleRepository.Query().Select(r => new RoleDto
            {
                Id = r.Id,
                Name = r.Name,
                Description = r.Description
            }).ToListAsync();

            return new RolesResponseModel
            {
                Data = roles,
                Status = true,
                Message = "Roles retrieved successfully"
            };
        }

        public async Task<BaseResponse> UpdateRole(int id, UpdateRoleRequestModel model)
        {
            var role = await _roleRepository.GetAsync(id);

            role.Name = model.Name;
            role.Description = model.Description;

            await _roleRepository.UpdateAsync(role);
            await _roleRepository.SaveChangesAsync();

            return new BaseResponse
            {
                Status = true,
                Message = "Role Updated Successfully"
            };
        }
    }
}
