﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities
{
    public class Farmer : Person
    {
        public string FarmerId { get; set; }
        public List<Animal> Animals { get; set; }
    }
}