using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public class RegisterModel
    {   [Required]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password required!")]
        [RegularExpression("^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9]).{8,16}$", ErrorMessage = "Password error")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage = "Password not match")]
        [Required(ErrorMessage = "Password empty")]
        public string ConfirmPassword { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
