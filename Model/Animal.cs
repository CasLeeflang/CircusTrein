using CircusTrein.Models;
using System;

namespace Model
{
    public class Animal : IAnimal
    {
        public int AnimalId { get; set; }
        public string Name { get; set; }
        public int Diet { get; set; }
        public int Size { get; set; }
        public bool IsSorted { get; set; }

        public Animal()
        {

        }

        public Animal(IAnimal animal)
        {
            AnimalId = animal.AnimalId;
            Name = animal.Name;
            Diet = animal.Diet;
            Size = animal.Size;
            IsSorted = animal.IsSorted;
        }
    }
}
