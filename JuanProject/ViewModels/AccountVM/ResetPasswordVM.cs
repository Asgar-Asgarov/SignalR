﻿
using System.ComponentModel.DataAnnotations;

namespace JuanProject.ViewModels.AccountVM
{
    public class ResetPasswordVM
    {
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password),Compare(nameof(Password))]
        public string ConfirmPassword { get; set;}
        public string Token { get; set; }
        public string UserId { get; set; }
    }
}