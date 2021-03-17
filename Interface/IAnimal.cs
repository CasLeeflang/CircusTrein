namespace CircusTrein.Models
{
    public interface IAnimal
    {
        int AnimalId { get; set; }
        int Diet { get; set; }
        string Name { get; set; }
        int Size { get; set; }
        bool IsSorted { get; set; }

    }
}