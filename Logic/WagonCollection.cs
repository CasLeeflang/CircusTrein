using DAL;
using DTOs;
using Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class WagonCollection
    {
        private List<Wagon> Wagons { get; } = new List<Wagon>();

        WagonDAL _wagonDAL = new();

        public void Initialise(int length)
        {
            for (int i = 0; i <= length; i++)
            {
                Wagons.Add(new Wagon());
            }
            _wagonDAL.InitializeWagons(length);
        }

        //Clears the wagons, used when a new train is generated
        public void ClearWagons()
        {
            Wagons.Clear();
            _wagonDAL.ClearWagons();
        }

        public void AddWagon(Animal animal)
        {
            Wagon wagon = new Wagon();
            wagon.AddAnimalToWagon(animal);
            Wagons.Add(wagon);
        }

        public IEnumerable<Wagon> GetCollectionWagons()
        {
            return Wagons;
        }

        public IEnumerable<Wagon> GetWagons()
        {
            var wagonDTOs = _wagonDAL.GetWagons();
            foreach (var wagonDTO in wagonDTOs)
            {
                Wagon wagon = new Wagon(wagonDTO.GetAnimalDTOs());
                Wagons.Add(wagon);
            }
            return Wagons;
        }

        public void SaveWagons()
        {
            foreach (var Wagon in Wagons)
            {
                WagonDTO wagonDTO = new WagonDTO();

                foreach (var animal in Wagon.GetAnimals())
                {
                    AnimalDTO animalDTO = new AnimalDTO
                    {
                        Name = animal.Name,
                        Diet = animal.Diet,
                        Size = animal.Size
                    };
                    wagonDTO.AddAnimal(animalDTO);
                }
                _wagonDAL.AddWagon(wagonDTO);
            }
            Wagons.Clear();
        }
    }
}
