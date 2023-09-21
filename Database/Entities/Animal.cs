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
        public string? Description { get; set; }
        public int? ProduteurId { get; set; }
        public string? PhotoPath { get; set; }

    }
}
