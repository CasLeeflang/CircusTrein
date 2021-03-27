namespace Interface
{
    public interface IAnimal
    {
        int AnimalId { get; }
        int Diet { get;}
        string Name { get;}
        int Size { get;}
        public bool WillEat(IAnimal animal);
        
    }
}