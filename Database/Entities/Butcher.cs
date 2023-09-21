using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Entities
{
    public class Butcher : Person
    {
        public string ButcherId { get; set; }
        public string Specialization { get; set; }


    }
}
