﻿using FSH.BlazorWebAssembly.Shared.Identity;
using FSH.BlazorWebAssembly.Shared.Requests.Identity;
using FSH.BlazorWebAssembly.Shared.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FSH.BlazorWebAssembly.Client.Infrastructure.Identity.Roles
{
    public interface IRoleService : IApiService
    {
        Task<IResult<List<RoleDto>>> GetRolesAsync();

        Task<IResult<string>> SaveAsync(RoleRequest role);

        Task<IResult<string>> DeleteAsync(string id);

        // Task<IResult<PermissionResponse>> GetPermissionsAsync(string roleId);

        // Task<IResult<string>> UpdatePermissionsAsync(PermissionRequest request);
    }
}