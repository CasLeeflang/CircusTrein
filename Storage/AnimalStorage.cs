using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Storage
{
    public static class AnimalStorage
    {
        private static List<AnimalDTO> animals { get; set; } = new List<AnimalDTO>();

        public static IEnumerable<AnimalDTO> GetAnimalList()
        {
            return animals;
        }
        public static void AddAnimalToList(AnimalDTO animal)
        {
            animals.Add(animal);
        }

        public static void DeleteAnimal(int animalId)
        {
            var selected = animals.First(o => o.AnimalId == animalId);
            animals.Remove(selected);
        }
        public static int GetMaxId()
        {
            if (animals.Count() > 0)
            {
                return animals.OrderBy(o => o.AnimalId).Last().AnimalId;

            }
            else
            {
                return 0;
            }
        }
    }
}
