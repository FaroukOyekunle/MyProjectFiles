using LibraryManagementSystem.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementSystem.Models
{
    public class RoleViewModel
    {
        public class CreateRoleRequestModel
        {
            public string Name { get; set; }
            public string Description { get; set; }
        }

        public class UpdateRoleRequestModel
        {
            public string Name { get; set; }
            public string Description { get; set; }
        }

        public class RoleResponseModel : BaseResponse
        {
            public RoleDto Data { get; set; }
        }

        public class RolesResponseModel : BaseResponse
        {
            public IEnumerable<RoleDto> Data { get; set; } = new List<RoleDto>();
        }

    }
    
}
