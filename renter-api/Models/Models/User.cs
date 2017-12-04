﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Models.Models
{
    public class User
    {
        [Key]
        [StringLength(256)]
        public string Id { get; set; }
        [Required]
        [StringLength(64)]
        public string Email { get; set; }
        [Required]
        [StringLength(64)]
        public string UserName { get; set; }
        [Required]
        [StringLength(64)]
        public string Password { get; set; }

        public int RoleId { get; set; }
        public virtual Role Role { get; set; }
    }
}