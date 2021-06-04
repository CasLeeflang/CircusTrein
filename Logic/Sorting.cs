using Storage;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class Sorting
    {
        WagonCollection _wagonCollection = new();

        public IEnumerable<Wagon> Sort(IEnumerable<Animal> animals)
        {
            _wagonCollection.ClearWagons();


            foreach (var animal in animals.OrderByDescending(o => o.Diet).ThenByDescending(o => o.Size))
            {
                bool allocated = false;

                foreach (var wagon in _wagonCollection.GetCollectionWagons().OrderBy(o => Convert.ToInt32(o.FreeSpots)))
                {
                    if (wagon.AddAnimalToWagon(animal))
                    {
                        allocated = true;
                        break;
                    }
                }

                if (allocated == false)
                {
                    _wagonCollection.AddWagon(animal);  //  Animal fits but not compatible
                }
            }

            _wagonCollection.SaveWagons();

            return _wagonCollection.GetWagons();
        }
    }
}
