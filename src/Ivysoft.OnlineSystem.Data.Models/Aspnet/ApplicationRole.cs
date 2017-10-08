using Microsoft.AspNetCore.Identity;

namespace Ivysoft.OnlineSystem.Data.Models.Aspnet
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() 
            : base()
        {

        }

        public ApplicationRole(string name) 
            : base(name)
        {

        }

        public string Description { get; set; }
    }
}
