using Microsoft.AspNetCore.Identity;

namespace LoginSystem.Models {
    public class Users : IdentityUser {
        public string FullName { get; set; }
    }
}
