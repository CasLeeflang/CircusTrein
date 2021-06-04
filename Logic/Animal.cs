using DTOs;
using System;
using Variables;

namespace Logic
{
    public class Animal
    {
        public int AnimalId { get; private set; }
        public string Name { get; private set; }
        public Diet Diet { get; private set; }
        public Size Size { get; private set; }


        // Check whether the animal wants to eat the another animal
        // Can be seen as the instinct of the animal.
        public bool WillEat(Animal animal)
        {
            if (Diet == Diet.Carnivore && Size >= animal.Size)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Animal(int animalId, string animalName, Diet animalDiet, Size animalSize)
        {
            AnimalId = animalId;
            Name = animalName;
            Diet = animalDiet;
            Size = animalSize;
        }
        public Animal(string animalName, Diet animalDiet, Size animalSize)
        {
            Name = animalName;
            Diet = animalDiet;
            Size = animalSize;
        }
        public Animal(AnimalDTO animalDTO)
        {
            AnimalId = animalDTO.AnimalId;
            Name = animalDTO.Name;
            Diet = animalDTO.Diet;
            Size = animalDTO.Size;
        }
    }
}
