using System.Collections.Generic;

namespace Interface
{
    public interface IWagon
    {
        List<IAnimal> Animals { get; set; }
        int FreeSpots { get;}
        bool Used { get;}
        public bool FitAnimal(IAnimal animal);
    }
}