using Storage;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class Sorting
    {
        WagonCollection _wagonCollection = new();

        public void Sort(IEnumerable<Animal> animals)
        {
            _wagonCollection.Initialise(0);


            foreach (var animal in animals)
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
        }
    }
}
