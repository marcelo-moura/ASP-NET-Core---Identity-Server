using Microsoft.AspNetCore.Identity;

namespace ProjectIdentityServer.Web.Model
{
    public class ApplicationUser : IdentityUser
    {
        private string FirstName { get; set; }
        private string LastName { get; set; }
    }
}
