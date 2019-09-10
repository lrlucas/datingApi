using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        [StringLength(9, MinimumLength = 3, ErrorMessage = "This user is already registered, please choose another")]
        public string Username { get; set; }
        
        [Required]
        [StringLength(9, MinimumLength = 4, ErrorMessage = "You must specify password between 4 and 8 character")]
        public string Password { get; set; }
    }
}