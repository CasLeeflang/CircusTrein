
using Interface;
using System;

namespace Model
{
    public class Animal : IAnimal
    {
        public int AnimalId { get; private set; }
        public string Name { get; private set; }
        public int Diet { get; private set; }
        public int Size { get; private set; }


        // Check whether the animal wants to eat the another animal
        // Can be seen as the instinct of the animal.
        public bool WillEat(IAnimal animal)
        {
            if (Diet == 1 && Size >= animal.Size)
            {
                return true;
            }
            else{ return false; }            
        }

        public Animal(int animalId, string animalName, int animalDiet, int animalSize)
        {
            AnimalId = animalId;
            Name = animalName;
            Diet = animalDiet;
            Size = animalSize;
        }
    }
}
