using Microsoft.EntityFrameworkCore;
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
        [Required(ErrorMessage = "Le nom est requis.")]
        public string Name { get; set; } = default!;
        [Required(ErrorMessage = "Le prénom est requis.")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "L'age est requis.")]
        [Range(18, 99, ErrorMessage = "L'âge doit être compris entre 18 et 99.")]
        public int Age { get; set; }
        [Required(ErrorMessage = "L'adresse est requis.")]
        public string Adress { get; set; }
        [Required(ErrorMessage = "Le numéro de téléphone est requis.")]
        public string Tel {  get; set; }
        [Required(ErrorMessage = "L'email est requis.")]
        public string Email { get; set; }
    }
}
