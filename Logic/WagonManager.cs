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
        //Clears the wagons, used when a new train is generated
        public static void ClearWagons()
        {           
            foreach (var wagon in Storage.WagonStorage.GetWagons())
            {                
                wagon.Animals = new List<IAnimal>();
            }

        }

        //Adds animal to a wagon
        public static void AddAnimalToWagon(IAnimal animal, IWagon wagon)
        {
            wagon.Animals.Add(animal); 
        }
    }
}
