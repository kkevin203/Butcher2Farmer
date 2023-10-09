﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities
{
    public abstract class Person
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public string? FirstName { get; set; }
        public int Age { get; set; }
        public string? Email { get; set;}
    }
}
