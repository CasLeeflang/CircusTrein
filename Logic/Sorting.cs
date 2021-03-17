using CircusTrein.Models;
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
                if (!animal.IsSorted)
                {
                    foreach (var wagon in WagonStorage.GetWagons().OrderBy(o => o.FreeSpots))
                    {
                        //Check constrain 1
                        if (Constraint1(animal, wagon) && Constraint2(animal, wagon) && !animal.IsSorted)
                        {
                            WagonManager.AddAnimalToWagon(animal, wagon);                            
                        }
                    }
                }
            }
        }


        //Wagon storage constraint
        public static bool Constraint1(IAnimal animal, IWagon wagon)
        {
            if (wagon.Animals != null)
            {                
                if (wagon.FreeSpots - animal.Size >= 0)
                {
                    return true;
                }

                else { return false; }
            }
            else { return true; }
        }

        //Animals eating eachother constraint
        public static bool Constraint2(IAnimal animal, IWagon wagon)
        {
            bool Possible = true;

            foreach (var animalWagon in wagon.Animals)
            {

                if (animalWagon.Diet == 1 && animalWagon.Size >= animal.Size)
                {
                    Possible = false;
                }

                if (animal.Diet == 1 && animal.Size >= animalWagon.Size)
                {
                    Possible = false;
                }
            }

            return Possible;
        }


    }
}
