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
        private static List<IWagon> wagons { get; set; } = new List<IWagon>();
        public static IEnumerable<IWagon> GetWagons()
        {
            return wagons;
        }

        public static void CreateWagonList(int length)
        {
            for (int i = 0; i <= length; i++)
            {
                wagons.Add(new Wagon());
            }            
        }

        public static void AddWagon(IWagon wagon)
        {
            wagons.Add(wagon);
        }
        public static void ClearWagons()
        {
            wagons = new List<IWagon>();
        }
    }
}
