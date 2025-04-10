//using CarRentalManagement.Server.Models;
//using IdentityServer4.Models;
//using System.Collections.Generic;
//using System.Security.Claims;
//using System.Threading.Tasks;
//using IdentityServer4.Services;
//using Microsoft.AspNetCore.Identity;
//using System.Linq;

//namespace CarRentalManagement.Server.Services
//{
//    public class ProfileService : IProfileService
//    {
//        private readonly UserManager<ApplicationUser> _userManager;

//        public ProfileService(UserManager<ApplicationUser> userManager)
//        {
//            _userManager = userManager;
//        }

//        public async Task GetProfileDataAsync(ProfileDataRequestContext context)
//        {
//            // Get user data from the Identity Server user store
//            var user = await _userManager.GetUserAsync(context.Subject);

//            if (user != null)
//            {
//                var roles = await _userManager.GetRolesAsync(user);
//                var claims = new List<Claim>
//            {
//                new Claim("sub", user.Id),
//                new Claim("preferred_username", user.UserName)
//            };

//                // Add roles as claims
//                claims.AddRange(roles.Select(role => new Claim("role", role)));

//                context.IssuedClaims.AddRange(claims);
//            }
//        }

//        public Task IsActiveAsync(IsActiveContext context)
//        {
//            return Task.CompletedTask;
//        }
//    }
//}
