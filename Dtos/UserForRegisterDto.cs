using System;
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

        [Required]
        public string KnownAs { get; set; }
        
        [Required]
        public DateTime DateOfBirth { get; set; }
        
        [Required]
        public string City { get; set; }
        
        [Required]
        public string Country { get; set; }
        
        public DateTime Created { get; set; }
        
        public DateTime LastActive { get; set; }
        

        public UserForRegisterDto()
        {
            Created = DateTime.Now;
            LastActive = DateTime.Now;
        }
        
        
    }
}