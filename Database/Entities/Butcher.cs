using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Database.Entities
{

    public class Butcher : Person
    {
        [JsonIgnore]
        public int ButcherId { get; set; }
        public string? Specialization { get; set; }
        public string? RaceFavorite { get; set; }
        public string? Description { get; set; }
        public string? PhotoPath { get; set; }


    }
}
