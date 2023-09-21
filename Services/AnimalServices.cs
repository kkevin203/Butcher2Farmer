
using Database;
using Database.Entities;

namespace Services
{
  

    public class AnimalService
    {

        ButcherDatabase _butcherDatabase;
        public AnimalService(ButcherDatabase butcherDatabase) 
        { 
            _butcherDatabase = butcherDatabase ?? throw new ArgumentNullException(nameof(butcherDatabase));
        }
  
        public List<Animal> GetAnimals()
        {
            var animals = _butcherDatabase.Animals.ToList();
            return animals;
        }
        public void AddAnimal(Animal animal)
        {
            // Assurez-vous que l'animal n'a pas déjà un ID
            if (animal.Id == 0)
            {
                // Si l'animal n'a pas d'ID, attribuez-lui un nouvel ID
               // animal.Id = nextAnimalId;
               // nextAnimalId++;

                // Ajoutez l'animal à la liste (ou à la base de données, selon votre cas)
                _butcherDatabase.Animals.Add(animal);
                _butcherDatabase.SaveChanges();                
            }
            else
            {
                UpdateAnimal(animal);
                // Si l'animal a déjà un ID, cela signifie qu'il s'agit d'une mise à jour.
                // Vous pouvez implémenter la logique de mise à jour ici.
                // Par exemple, mettez à jour l'animal dans la base de données s'il s'agit d'Entity Framework.
            }
        }
        public void DeleteAnimal(int animalId)
        {
            // Recherchez l'animal à supprimer dans la base de données en utilisant son ID.
            var animalToDelete = _butcherDatabase.Animals.FirstOrDefault(a => a.Id == animalId);

            if (animalToDelete != null)
            {
                // Si l'animal est trouvé, supprimez-le de la base de données.
                _butcherDatabase.Animals.Remove(animalToDelete);
                _butcherDatabase.SaveChanges();
            }
            // Sinon, vous pouvez gérer le cas où l'animal n'est pas trouvé ou gérer les erreurs comme vous le souhaitez.
        }
        public void UpdateAnimal(Animal animal)
        {
            // Recherchez l'animal à mettre à jour dans la base de données en utilisant son ID.
            var existingAnimal = _butcherDatabase.Animals.FirstOrDefault(a => a.Id == animal.Id);

            if (existingAnimal != null)
            {
                // Mettez à jour les propriétés de l'animal existant avec les nouvelles valeurs.
                existingAnimal.Name = animal.Name;

                // Enregistrez les modifications dans la base de données.
                _butcherDatabase.SaveChanges();
            }
            // Sinon, vous pouvez gérer le cas où l'animal n'est pas trouvé ou gérer les erreurs comme vous le souhaitez.
        }

    }
}
