using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities
{
    [PrimaryKey("Id")]
    public class Animal
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public float? Price { get; set; }
        public string? Race { get; set; }
        public int? weight { get; set; }
        public string? Description { get; set; }
        public string? FarmerName { get; set; }
        public int FarmerId { get; set; }
        public string? PhotoPath { get; set; }
        public string? Categorization { get; set; }
        public string? stabling { get; set; }


    }
}
