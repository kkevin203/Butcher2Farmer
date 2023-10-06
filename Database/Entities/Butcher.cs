using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities
{
    [PrimaryKey("Id")]

    public class Butcher : Person
    {
        public int ButcherId { get; set; }
        public string? Specialization { get; set; }
        public string? RaceFavorite { get; set; }
        public string? Description { get; set; }
        public string? PhotoPath { get; set; }


    }
}
