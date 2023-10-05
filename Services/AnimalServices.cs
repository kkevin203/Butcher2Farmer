
using Database;
using Database.Entities;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.EntityFrameworkCore;

namespace Services
{
  

    public class AnimalService
    {

        ButcherDatabase _butcherDatabase;
        public AnimalService(ButcherDatabase butcherDatabase) 
        { 
            _butcherDatabase = butcherDatabase ?? throw new ArgumentNullException(nameof(butcherDatabase));
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
            if (animal.Id == 0)
            {
                _butcherDatabase.Animals.Add(animal);
                _butcherDatabase.SaveChanges();                
            }
            else
            {
                UpdateAnimal(animal);
            
            }
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
