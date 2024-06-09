using Microsoft.AspNetCore.Identity;

namespace AuthenticationAspNetIdentity
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; } = "Juan";
        public string Password { get; set; } = "123";
    }
}
