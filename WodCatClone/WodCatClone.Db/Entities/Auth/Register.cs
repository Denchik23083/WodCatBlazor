﻿using System;
using System.ComponentModel.DataAnnotations;

namespace WodCatClone.Db.Entities.Auth
{
    public class Register
    {
        public int Id { get; set; }

        public string Name { get; set; }
        
        public string Surname { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string NickName { get; set; }

        public int GenderId { get; set; }

        public DateTime Birthday { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string ConfirmPassword { get; set; }
    }
}
