﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = default!;
        public int Age { get; set; }
        public string Email { get; set;}
    }
}
