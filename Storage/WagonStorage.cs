using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Interface;

namespace Storage
{
    public class WagonStorage
    {
        public static List<IWagon> wagons = new List<IWagon> { new Wagon(), new Wagon(), new Wagon(), new Wagon(), new Wagon(), new Wagon(), new Wagon() };

        public static List<IWagon> GetWagons()
        {
            return wagons;
        }
    }
}
