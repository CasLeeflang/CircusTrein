using System.Collections.Generic;

namespace CircusTrein.Models
{
    public interface IWagon
    {
        List<IAnimal> Animals { get; set; }
        int FreeSpots { get;}
        bool Used { get; set; }

       
    }
}