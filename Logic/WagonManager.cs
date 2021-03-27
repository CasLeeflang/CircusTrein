
using Interface;
using Model;
using Storage;
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
                wagon.ResetAnimalList();
            }
        }

        //Adds animal to a wagon
        public static void AddAnimalToWagon(IAnimal animal, IWagon wagon)
        {
            wagon.AddAnimalToWagon(animal);
        }

        public static void CreateWagonWithAnimal(IAnimal animal)
        {
            var wagonWithAnimal = new Wagon(animal);
            WagonStorage.AddWagon(wagonWithAnimal);

        }

        public static IEnumerable<IWagon> GetWagons()
        {
            return WagonStorage.GetWagons();
        }
    }
}
