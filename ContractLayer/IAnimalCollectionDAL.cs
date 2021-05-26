using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractLayer
{
    public interface IAnimalCollectionDAL
    {
        void CreateAnimal(AnimalDTO animalDTO);
        IEnumerable<AnimalDTO> GetAllAnimals();
        void DeleteAnimal(int animalId);
        int GetMaxAnimalId();
    }
}
