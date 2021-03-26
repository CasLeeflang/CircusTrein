
using Interface;
using Storage;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class Sorting
    {
        public static void CheckForConstraints(List<IAnimal> animals)
        {
            foreach (var animal in animals)
            {
                foreach (var wagon in WagonStorage.GetWagons().OrderBy(o => o.FreeSpots))
                {
                    if (wagon.FitAnimal(animal))
                    {
                        if (wagon.Used)
                        {

                            //Check for all animals already in the wagon whether they will eat the potential new animal and vice versa
                            //If they dont, the animal is passed, else it does not

                            bool passed = false; 

                            foreach (var animalInWagon in wagon.GetAnimals())
                            {
                                Console.WriteLine(wagon.GetAnimals()) ;
                                if (!animal.WillEat(animalInWagon) && !animalInWagon.WillEat(animal))
                                {
                                    Console.WriteLine();
                                    passed = true;
                                }
                                else { passed = false;}
                            }

                            if (passed)
                            {                                
                                WagonManager.AddAnimalToWagon(animal, wagon);
                                break;
                            }
                        }

                        //If the wagon is empty the animal can be added right away
                        else
                        {
                            WagonManager.AddAnimalToWagon(animal, wagon);
                            break;
                        }

                    }
                }
            }
        }
    }
}
