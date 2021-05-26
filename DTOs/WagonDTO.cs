using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public class WagonDTO
    {
        private List<AnimalDTO> Animals { get; } = new List<AnimalDTO>();
                
        public IEnumerable<AnimalDTO> GetAnimalDTOs()
        {
            return Animals;
        }

        public void AddAnimal(AnimalDTO animalDTO)
        {
            Animals.Add(animalDTO);
        }
    }
}
