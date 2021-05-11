using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sklep.ViewModels
{
    public class LoginViewmModel
    {

    }

    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Musisz podać adres e-mail")]
        [EmailAddress]
        [Display(Name = "Adres e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Musisz podać hasło")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Musisz podać hasło")]
        [DataType(DataType.Password)]
        [Display(Name = "Potwierdź hasło")]
        [Compare(nameof(Password), ErrorMessage = "Hasła muszą być identyczne.")]
        public string ConfirmPassword { get; set; }
    }
}