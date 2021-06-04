using ContractLayer;
using Dapper;
using DTOs;
using Storage;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DAL
{
    public class AnimalDAL : IAnimalCollectionDAL
    {
        public void CreateAnimal(AnimalDTO animalDTO)
        {

            AnimalStorage.AddAnimalToList(animalDTO);
        }

        public IEnumerable<AnimalDTO> GetAllAnimals()
        {
            return AnimalStorage.GetAnimalList();
        }
        public void DeleteAnimal(int animalId)
        {
            AnimalStorage.DeleteAnimal(animalId);
        }
        public int GetMaxAnimalId()
        {
            return AnimalStorage.GetMaxId();
        }
    }

}
