using Microsoft.AspNetCore.Identity;
using ARMB.Domain.Entities;
using ARMB.API.Data;

namespace ARMB.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        
         public string FullName { get; set; } = string.Empty;
    }
}
