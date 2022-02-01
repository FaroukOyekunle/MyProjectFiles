using LibraryManagementSystem.Dtos;
using LibraryManagementSystem.Entities;
using LibraryManagementSystem.Interfaces.Identity;
using LibraryManagementSystem.Interfaces.IServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static LibraryManagementSystem.Models.RoleViewModel;

namespace LibraryManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        private readonly IIdentityService _identityService;
        private readonly UserManager<User> _userManager;


        public RoleController(IRoleService roleService, IIdentityService identityService, UserManager<User> userManager)
        {
            _roleService = roleService;
            _identityService = identityService;
            _userManager = userManager;
        }

        //[Authorize(Roles = "IDHAdmin")]
        [HttpPost]
        //[ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse))]
        //[ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ValidationResultModel))]
        //[ProducesResponseType((int)HttpStatusCode.Unauthorized, Type = typeof(BaseResponse))]
        public async Task<IActionResult> Create([FromBody] CreateRoleRequestModel model)
        {
            var response = await _roleService.AddRole(model);
            return Ok(response);
        }

        // [Authorize]
        [HttpGet("{id}")]
        // [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(RoleResponseModel))]
        // [ProducesResponseType((int)HttpStatusCode.Unauthorized, Type = typeof(BaseResponse))]
        public async Task<IActionResult> GetRole([FromRoute] int id)
        {
            // var userId = Guid.Parse(_identityService.GetUserIdentity());
            var response = await _roleService.GetRole(id);
            return Ok(response);
        }

        /* [Authorize(Roles = "IDHAdmin")]
         [HttpPut("{id}")]
         [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(BaseResponse))]
         [ProducesResponseType((int)HttpStatusCode.BadRequest, Type = typeof(ValidationResultModel))]
         [ProducesResponseType((int)HttpStatusCode.Unauthorized, Type = typeof(BaseResponse))]
         public async Task<IActionResult> Update(Guid id, [FromBody] UpdateRoleRequestModel model)
         {
             var response = await _roleService.UpdateRoleAsync(id, model);
             return Ok(response);
         }
         [Authorize(Roles = "IDHAdmin,IPAdmin,IDHProgramAdmin")]
         [HttpGet]
         [ProducesResponseType((int)HttpStatusCode.OK, Type = typeof(RolesResponseModel))]
         [ProducesResponseType((int)HttpStatusCode.Unauthorized, Type = typeof(BaseResponse))]
         public async Task<IActionResult> GetRoles()
         {
             var userId = Guid.Parse(_identityService.GetUserIdentity());
             var isGlobalAdmin = await _userManager.IsInRoleAsync(new User { Id = userId }, Constants.IDHAdminRole);
             var isProgramAdmin = await _userManager.IsInRoleAsync(new User { Id = userId }, Constants.IDHProgramAdminRole);
             var response = await _roleService.GetRoles(isGlobalAdmin, isProgramAdmin);
             return Ok(response);
         }
         [Authorize(Roles = "IDHAdmin,IPAdmin")]
         [HttpGet("data")]
         public async Task<IActionResult> LoadRoles(DatatableRequest datatable)
         {
             var page = datatable.Pagination.Page;
             var limit = datatable.Pagination.PerPage;
             var filter = await datatable.Query.Get("filter",
                                                    () => Task.FromResult<string?>(null),
                                                    s => string.IsNullOrWhiteSpace(s)
                                                             ? null
                                                             : s.Trim());
             var instances =
                 await _roleService.LoadRolesAsync(filter,
                                                                  page,
                                                                  limit);
             var totalPages = (instances.TotalCount + limit - 1) / limit;
             var list = instances.Rows.ToList();
             var meta = new
             {
                 page,
                 perpage = limit,
                 pages = totalPages,
                 total = instances.TotalCount
             };
             return Ok(new
             {
                 meta,
                 data = list
             });
         }*/
    }
}
