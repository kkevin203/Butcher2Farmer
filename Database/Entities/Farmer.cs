using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Database.Entities
{

    public class Farmer : Person
    {
        [JsonIgnore]
        public int FarmerId { get; set; }
        public List<Animal>? Animals { get; set; }
        [Required(ErrorMessage = "La Certifications est requis.")]
        public string Certifications { get; set; }
        [Required(ErrorMessage = "Le type d'animal est requis.")]
        public string AnimalType { get; set; } // type d'animal
        [Required(ErrorMessage = "La quantité de bête est requis.")]
        public string farmerSize { get; set; } // taille de l'élevage


    }
}
