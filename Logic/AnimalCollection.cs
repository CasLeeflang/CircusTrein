using ContractLayer;
using DAL;
using DTOs;
using Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory;

namespace Logic
{
    public class AnimalCollection
    {
        private List<Animal> animals { get; } = new List<Animal>();
        IAnimalCollectionDAL _animalCollectionDAL = AnimalFactoryDAL.CreateAnimalCollectionDAL();

        public void AddAnimal(Animal animal)
        {

            AnimalDTO animalDTO = new AnimalDTO
            {
                AnimalId = animal.AnimalId,
                Name = animal.Name,
                Diet = animal.Diet,
                Size = animal.Size
            };

            _animalCollectionDAL.CreateAnimal(animalDTO);
        }

        public IEnumerable<Animal> GetAnimals()
        {
            animals.Clear();
            var animalDTOs = _animalCollectionDAL.GetAllAnimals();
            foreach (var animalDTO in animalDTOs)
            {
                Animal animal = new Animal(animalDTO);
                animals.Add(animal);
            }
            return animals;
        }

        //Validates whether the model is complete or not
        public bool ValidateModel(Animal animal)
        {         
            if(animal.Name != null && (animal.Diet == 0 || Convert.ToInt32(animal.Diet) == 1 ) && (Convert.ToInt32(animal.Size) == 1 || Convert.ToInt32(animal.Size) == 3 || Convert.ToInt32(animal.Size) == 5))
            {
                return true;
            }

            else { return false; }
        }    
        public int GetMaxAnimalId()
        {
            return _animalCollectionDAL.GetMaxAnimalId();
        }
        public void DeleteAnimal(int animalId)
        {
            _animalCollectionDAL.DeleteAnimal(animalId);
        }
    }
}
