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
using Variables;

namespace Logic
{
    public class AnimalCollection
    {
        private List<Animal> animals { get; } = new List<Animal>();
        IAnimalCollectionDAL _animalCollectionDAL = AnimalFactoryDAL.CreateAnimalCollectionDAL();

        public bool AddAnimal(Animal animal)
        {            
            if (ValidateModel(animal))
            {
                AnimalDTO animalDTO = new AnimalDTO
                {
                    AnimalId = GetNewMaxAnimalId(),
                    Name = animal.Name,
                    Diet = animal.Diet,
                    Size = animal.Size
                };

                _animalCollectionDAL.CreateAnimal(animalDTO);
                return true;
            }
            else
            {
                return false;
            }
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
        private bool ValidateModel(Animal animal)
        {
            if (animal.Name != null && (animal.Diet == 0 || Convert.ToInt32(animal.Diet) == 1) && (Convert.ToInt32(animal.Size) == 1 || Convert.ToInt32(animal.Size) == 3 || Convert.ToInt32(animal.Size) == 5))
            {

                return true;
            }

            else { return false; }
        }

        private int GetNewMaxAnimalId()
        {
            return _animalCollectionDAL.GetMaxAnimalId() + 1;
        }

        public void DeleteAnimal(int animalId)
        {
            _animalCollectionDAL.DeleteAnimal(animalId);
        }
    }
}
