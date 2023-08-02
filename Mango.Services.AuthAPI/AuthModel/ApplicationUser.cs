using Microsoft.AspNetCore.Identity;

namespace Mango.Services.AuthAPI.AuthModel
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }

    }
}
