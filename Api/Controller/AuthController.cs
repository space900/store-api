using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controller
{
    public class AuthController : StoreController
    {
        public AuthController(
            AppDbContext dbContext,
            UserManager<AppUser> userManager
            RoleManager<IdentityRole> roleManager
        )
            : base(dbContext)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
        }
    }
}