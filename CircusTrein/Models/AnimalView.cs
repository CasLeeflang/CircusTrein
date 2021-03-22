using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace CircusTrein.Models
{
    public class AnimalView
    {
        public int AnimalId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required]
        public int Diet { get; set; } // 0 for herbivore, 1 for carnivore 

        [Required]
        public int Size { get; set; } // 1 for small, 3 for medium, 5 for large        

    }
}
