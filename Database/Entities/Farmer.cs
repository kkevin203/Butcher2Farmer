using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Database.Entities
{
    [PrimaryKey("Id")]

    public class Farmer : Person
    {
        public int FarmerId { get; set; }
        public List<Animal>? Animals { get; set; }

    }
}
