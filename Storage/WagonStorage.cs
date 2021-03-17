using CircusTrein.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Storage
{
    public class WagonStorage
    {
        public static List<IWagon> wagons = new List<IWagon> { new Wagon() , new Wagon(), new Wagon(), new Wagon(), new Wagon(), new Wagon(), new Wagon()};

        public static List<IWagon> GetWagons()
        {
            return wagons;
        }         

        public static void AddWagon(IAnimal animal)
        {
            IWagon wagon = new Wagon(animal);
            wagons.Add(wagon);
        }

        public static void AddAnimalToWagon(IAnimal animal, IWagon wagon)
        {
            wagon.Animals.Add(animal);
        }       
    }
}
