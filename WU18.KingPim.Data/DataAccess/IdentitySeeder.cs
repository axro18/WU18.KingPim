using Microsoft.AspNetCore.Identity;
using System.Linq;
using WU18.KingPim.Data.Models;

namespace WU18.KingPim.Data.DataAccess
{
    public class IdentitySeeder : IIdentitySeeder
    {
        private const string _admin = "admin";
        private const string _password = "Test123!";

        private readonly KingPimContext _ctx;
        private readonly UserManager<User> _userManager;

        public IdentitySeeder(KingPimContext ctx, UserManager<User> userManager)
        {
            _ctx = ctx;
            _userManager = userManager;
        }

        public bool CreateAdminAccountIfEmpty()
        {
            if (!_ctx.Users.Any(u => u.UserName == _admin))
            {
                var result = _userManager.CreateAsync(new User()
                {
                    UserName = _admin,
                    Email = "admin@kingpim.com",
                    EmailConfirmed = true
                }, _password).Result;
            }
            return true;
        }
    }
}