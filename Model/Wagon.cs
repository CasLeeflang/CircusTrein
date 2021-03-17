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
        public int FreeSpots { get; set; } = 10;
        public bool Used { get; set; } = false; 

        public Wagon()
        {
            Animals = new List<IAnimal>();
        }
        public Wagon(IAnimal animal)
        {
            Animals = new List<IAnimal> { new Animal(animal) };
        }

    }
}
