
using Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Storage
{
    public class AnimalStorage
    {  
        private static List<IAnimal> animals { get; set; }

        public static IEnumerable<IAnimal> GetAnimalList()
        {          
            return animals;
        }
        public static void AddAnimalToList(IAnimal animal)
        {
            animals.Add(animal);
        }

        public static void RemoveAnimalFromList(int animalId)
        {
            var selected = animals.FirstOrDefault(o => o.AnimalId == animalId);
            animals.Remove(selected);
        }
    }
}
    