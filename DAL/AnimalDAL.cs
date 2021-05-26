using Dapper;
using DTOs;
using Storage;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DAL
{
    public class AnimalDAL
    {
        public void CreateAnimal(AnimalDTO animalDTO)
        {

            AnimalStorage.AddAnimalToList(animalDTO);
        }

        public IEnumerable<AnimalDTO> GetAllAnimals()
        {
            return AnimalStorage.GetAnimalList();
        }
    }

}
