﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Models.Models
{
    public class Director
    {
        [Key]
        public long Id { get; set; }
        [Required]
        [StringLength(32)]
        public string Name { get; set; }
        [Required]
        [StringLength(32)]
        public string Surname { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}