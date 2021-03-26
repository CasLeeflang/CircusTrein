using System.Collections.Generic;

namespace Interface
{
    public interface IWagon
    {
        //IEnumerable<IAnimal> Animals { get; set; }
        int FreeSpots { get;}
        bool Used { get;}
        public bool FitAnimal(IAnimal animal);
        public IEnumerable<IAnimal> GetAnimals();
        public void AddAnimalToWagon(IAnimal animal);
        public void ResetAnimalList();
    }
}