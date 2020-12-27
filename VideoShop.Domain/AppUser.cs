using Microsoft.AspNetCore.Identity;

namespace VideoShop.Domain
{
    public class AppUser: IdentityUser<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}