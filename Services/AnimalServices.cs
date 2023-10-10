
using Database;
using Database.Entities;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services
{


    public class AnimalService
    {
        private readonly ButcherDatabase _butcherDatabase;
        private readonly FarmerService _farmerService;

        public AnimalService(ButcherDatabase butcherDatabase, FarmerService farmerService)
        {
            _butcherDatabase = butcherDatabase ?? throw new ArgumentNullException(nameof(butcherDatabase));
            _farmerService = farmerService ?? throw new ArgumentNullException(nameof(farmerService));
        }

        public async Task<List<Animal>> GetAnimalsAsync()
        {
            var animals = await _butcherDatabase.Animals.ToListAsync();
            return animals;
        }
        public async Task<Animal> GetAnimalByIdAsync(int animalId)
        {

            var animal = await _butcherDatabase.Animals.FirstOrDefaultAsync(a => a.Id == animalId);
            return animal;
        }

        public void AddAnimal(Animal animal)
        {
            if (animal.FarmerId == 0)
            {
                animal.FarmerId = 1;
            }

            var selectedFarmer = _farmerService.GetFarmerById(animal.FarmerId);
            if (selectedFarmer != null)
            {
                animal.FarmerName = $"{selectedFarmer.FirstName} {selectedFarmer.Name}";
            }

            if (animal.Id == 0)
            {
                _butcherDatabase.Animals.Add(animal);
            }
            else
            {
                UpdateAnimal(animal);
            }

            _butcherDatabase.SaveChanges();
        }

        public void DeleteAnimal(int animalId)
        {
            var animalToDelete = _butcherDatabase.Animals.FirstOrDefault(a => a.Id == animalId);

            if (animalToDelete != null)
            {
                _butcherDatabase.Animals.Remove(animalToDelete);
                _butcherDatabase.SaveChanges();
            }
        }
        public void UpdateAnimal(Animal animal)
        {
            var existingAnimal = _butcherDatabase.Animals.FirstOrDefault(a => a.Id == animal.Id);

            if (existingAnimal != null)
            {
                existingAnimal.Name = animal.Name;

                // Ne mettez à jour la photo que si une nouvelle photo a été définie
                if (!string.IsNullOrWhiteSpace(animal.PhotoPath))
                {
                    existingAnimal.PhotoPath = animal.PhotoPath;
                }

                _butcherDatabase.SaveChanges();
            }
        }



    }
}
