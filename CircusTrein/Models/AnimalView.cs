using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace CircusTrein.Models
{
    public class AnimalView : IAnimal
    {
        public int AnimalId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required]
        public int Diet { get; set; }

        [Required]
        public int Size { get; set; }
         
        public bool IsSorted { get; set; } = false;

        public AnimalView()
        {

        }

        public AnimalView(IAnimal animal)
        {
            Name = animal.Name;
            Diet = animal.Diet;
            Size = animal.Size;
            IsSorted = animal.IsSorted;
        }
    }
}
