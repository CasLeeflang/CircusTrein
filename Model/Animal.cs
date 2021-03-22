using CircusTrein.Models;
using System;

namespace Model
{
    public class Animal : IAnimal
    {
        public int AnimalId { get; set; }
        public string Name { get; private set; }
        public int Diet { get; private set; }
        public int Size { get; private set; }


        //The two booleans bellow check whether the animal wants to eat the another animal or will be eaten by the other animal
        //Can be seen as the instinct of the animal.
        public bool WillEat(IAnimal animal)
        {
            if (Diet == 0)
            {
                return false;
            }
            if (Diet == 1 && Size >= animal.Size)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool WillBeEaten(IAnimal animal)
        {
            if(animal.Diet == 0)
            {
                return false;
            }
            if(animal.Diet == 1 && animal.Size >= Size)
            {
                return true;
            }
            else { return false; }
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
