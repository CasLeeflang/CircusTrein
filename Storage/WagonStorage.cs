using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    public static class WagonStorage
    {
        private static List<WagonDTO> wagons { get; set; } = new List<WagonDTO>();
        public static IEnumerable<WagonDTO> GetWagons()
        {
            return wagons;
        }

        public static void CreateWagonList(int length)
        {
            ClearWagons();
            for (int i = 0; i <= length; i++)
            {
                wagons.Add(new WagonDTO());
            }            
        }

        public static void AddWagon(WagonDTO wagon)
        {
            wagons.Add(wagon);
        }

        public static void ClearWagons()
        {
            wagons = new List<WagonDTO>();
        }
    }
}
