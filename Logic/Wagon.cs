using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class Wagon
    {
        private List<Animal> Animals { get; set; } = new List<Animal>();
        public int FreeSpots
        {
            get
            {
                //Rule so the prop is always correct
                return 10 - GetAnimals().Sum(e => Convert.ToInt32(e.Size));
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
                else
                {
                    return false;
                }
            }
        }
        public Wagon()
        {

        }

        public Wagon(IEnumerable<AnimalDTO> animalDTOs)
        {
            foreach (var animalDTO in animalDTOs)
            {
                Animal animal = new Animal(animalDTO);
                Animals.Add(animal);
            }
        }
        public bool AddAnimalToWagon(Animal animal)
        {
            if (FitAnimal(animal))
            {
                foreach (var _animal in Animals)
                {
                    if (_animal.WillEat(animal) || animal.WillEat(_animal))
                    {
                        return false;
                    }
                }

                Animals.Add(animal);
                return true;
            }
            else
            {
                return false;
            }
        }

        //Property to check if an animal would fit in the wagon.
        public bool FitAnimal(Animal animal)
        {
            if (FreeSpots - Convert.ToInt32(animal.Size) >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public IEnumerable<Animal> GetAnimals() // List with IEnumerable
        {
            return Animals;
        }




        public void ResetAnimalList()
        {
            Animals = new List<Animal>();
        }
    }
}
