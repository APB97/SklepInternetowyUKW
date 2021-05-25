using Sklep.Controllers;
using Sklep.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sklep.ViewModels
{
    public class ManageViewModel
    {
        public UserData UserData { get; set; }

        public ChangePasswordViewModel ChangePassword { get; set; }

        public ManageMessageId? Message { get; set; }
    }

    public class ChangePasswordViewModel
    {
        [Required(ErrorMessage = "Pole jest wymgaane")]
        [DataType(DataType.Password)]
        [Display(Name = "Current password")]
        public string OldPassword { get; set; }

        [Required(ErrorMessage = "Pole jest wymgaane")]
        [DataType(DataType.Password)]
        [Display(Name = "New password")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Pole jest wymgaane")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm new password")]
        [Compare("NewPassword", ErrorMessage = "Hasła muszą się zgadzać")]
        public string ConfirmPassword { get; set; }
    }
}