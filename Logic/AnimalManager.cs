using CircusTrein.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class AnimalManager
    {
        public static IAnimal SetId(IAnimal animal)
        {
            try
            {
                var maxId = Storage.AnimalStorage.GetAnimalList().Max(o => o.AnimalId);
                animal.AnimalId = maxId + 1;
            }
            catch { animal.AnimalId = 0; }          

            return animal;
        }

        public static bool ValidateModel(IAnimal animal)
        {
            bool isValid = false;

            if(animal.Name != null && (animal.Diet == 0 || animal.Diet == 1 ) && (animal.Size == 1 || animal.Size == 3 || animal.Size == 5))
            {
                isValid = true;
            }

            return isValid;
        }
    
    }
}
