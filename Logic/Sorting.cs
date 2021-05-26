using Storage;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Logic
{
    public class Sorting
    {
        WagonCollection _wagonCollection = new();

        public void Sort(List<Animal> animals)
        {
            _wagonCollection.Initialise(0);


            foreach (var animal in animals)
            {
                bool allocated = false;

                foreach (var wagon in _wagonCollection.GetCollectionWagons().OrderBy(o => Convert.ToInt32(o.FreeSpots)))
                {
                    if (wagon.AddAnimalToWagon(animal))
                    {
                        allocated = true;
                        break;
                    }

                }
                if (allocated == false)
                {
                    _wagonCollection.AddWagon(animal);  //  Animal fits but not compatible
                }
            }
            

            _wagonCollection.SaveWagons();
        }
    }
}





//if (wagon.FitAnimal(animal))
//{
//    if (wagon.Used)
//    {

//        //Check for all animals already in the wagon whether they will eat the potential new animal and vice versa
//        //If they dont, the animal is passed, else it does not

//        bool passed = false;

//        foreach (var animalInWagon in wagon.GetAnimals())
//        {
//            if (!animal.WillEat(animalInWagon) && !animalInWagon.WillEat(animal))
//            {
//                passed = true;
//            }
//            else
//            {
//                passed = false;
//            }
//        }

//        if (passed)
//        {
//            wagon.AddAnimalToWagon(animal);
//            break;
//        }
//        else
//        {
//            _wagonCollection.AddWagon(animal);  //  Animal fits but not compatible
//            break;
//        }
//    }

//    //If the wagon is empty the animal can be added right away
//    else
//    {
//        wagon.AddAnimalToWagon(animal);
//        break;
//    }
//}
//else
//{
//    _wagonCollection.AddWagon(animal);  //  Animal does not fit
//    break;
//}
