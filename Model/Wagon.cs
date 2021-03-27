
using Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Wagon : IWagon
    {
        private List<IAnimal> Animals { get; set; } = new List<IAnimal>();
        public int FreeSpots
        {
            get
            {
                //Rule so the prop is always correct
                return 10 - GetAnimals().Sum(e => e.Size);
            }
        }

        public bool Used
        {
            get
            {
                //Check if the wagon is empty or not
                if (GetAnimals().Count() > 0)
                {
                    return true;
                }
                else { return false; }
            }
        }
        public Wagon()
        {

        }
        public Wagon(IAnimal animal)
        {
            this.AddAnimalToWagon(animal);
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

        public IEnumerable<IAnimal> GetAnimals() // List with IEnumerable
        {
            return Animals;
        }

        public void AddAnimalToWagon(IAnimal animal )
        {
            Animals.Add(animal);
        }

        public void ResetAnimalList()
        {
            Animals = new List<IAnimal>();      
        }       
    }
}
