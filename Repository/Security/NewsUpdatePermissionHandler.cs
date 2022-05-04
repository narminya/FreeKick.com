using Domain.Constants;
using Domain.Entity;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Security
{
    class NewsUpdatePermissionHandler : AuthorizationHandler<NewsUpdateRequirement, News>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
                                                      NewsUpdateRequirement requirement,
                                                      News resource)
        {

            ClaimsPrincipal currentUser = context.User;
            if (resource.CreatedUserId == currentUser.FindFirst(ClaimTypes.NameIdentifier).Value)
            {
                context.Succeed(requirement);
            }
            else if (context.User.IsInRole(RoleConstants.Moderator))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }
    }
}

