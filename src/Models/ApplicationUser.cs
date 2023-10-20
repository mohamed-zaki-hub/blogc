using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace src.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required,MaxLength(100)]
        public string FristName { get; set; }
        [Required,MaxLength(100)]
        public string LastName { get; set; }

    }
}
