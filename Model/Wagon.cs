using CircusTrein.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Wagon : IWagon
    {
        public List<IAnimal> Animals { get; set; }
        public int FreeSpots
        {
            get
            {
                //Rule so the prop is always correct
                return 10 - Animals.Sum(e => e.Size);
            }
        }

        public bool Used
        {
            get
            {
                if (Animals.Count() > 0)
                {
                    return true;
                }
                else { return false; }
            }
        }

        //Property to check if an animal would fit in the wagon.
        public bool FitAnimal(IAnimal animal)
        {
            if (FreeSpots - animal.Size >= 0)
            {
                return true;
            }
            else { return false; }
        }
    }
}
