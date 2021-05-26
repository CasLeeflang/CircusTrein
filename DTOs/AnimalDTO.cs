using System;
using Variables;

namespace DTOs
{
    public class AnimalDTO
    {
        public int AnimalId { get; set; }
        public string Name { get; set; }
        public Diet Diet { get; set; }
        public Size Size { get; set; }
    }
}
