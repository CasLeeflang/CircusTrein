using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CircusTrein.Models
{
    public class WagonView : IWagon
    {
        public List<IAnimal> Animals { get; set; }
        public int FreeSpots { get; set; } = 10;
        public bool Used { get; set; } = false; 
        public WagonView()
        {
            Animals = new List<IAnimal>();
        }

        public WagonView(IAnimal animal)
        {
            Animals = new List<IAnimal> { new AnimalView(animal) }; 
        }
        
    }

}
