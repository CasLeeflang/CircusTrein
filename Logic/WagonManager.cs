using CircusTrein.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class WagonManager
    {
        public static void ClearWagons()
        {
            foreach (var animal in Storage.AnimalStorage.GetAnimalList())
            {
                animal.IsSorted = false;
            }
            foreach (var wagon in Storage.WagonStorage.GetWagons())
            {
                wagon.Used = false;
                wagon.Animals = new List<IAnimal>();
                wagon.FreeSpots = 10;
            }

        }

        public static void AddAnimalToWagon(IAnimal animal, IWagon wagon)
        {
            wagon.Animals.Add(animal);
            wagon.Used = true;
            animal.IsSorted = true;
            wagon.FreeSpots -= animal.Size;
        }
    }
}
