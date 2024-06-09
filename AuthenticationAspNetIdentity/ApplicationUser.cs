using Microsoft.AspNetCore.Identity;

namespace AuthenticationAspNetIdentity
{
    public class ApplicationUser : IdentityUser
    {
        public string FullName { get; set; }
        public DateTime Birthdate { get; set; }
    }
}
