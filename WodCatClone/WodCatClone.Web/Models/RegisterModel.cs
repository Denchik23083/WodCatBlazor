﻿using System.ComponentModel.DataAnnotations;
using WodCatClone.Db.Entities.Auth;

namespace WodCatClone.Web.Models
{
    public class RegisterModel
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Surname { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Email format is not right")]
        public string? Email { get; set; }

        [Required]
        public string? NickName { get; set; }

        [Required]
        public int? GenderId { get; set; }

        [Required]
        public Gender? Gender { get; set; }

        [Required]
        public DateTime Birthday { get; set; }

        [Required]
        public string? Town { get; set; }

        [Required]
        public string? Password { get; set; }

        [Required]
        public string? ConfirmPassword { get; set; }
    }
}
