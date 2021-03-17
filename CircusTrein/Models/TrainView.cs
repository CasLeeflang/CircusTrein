using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CircusTrein.Models
{
    public class TrainView
    {
        public List<IAnimal> Animals { get; set; }
        public List<IWagon> Wagons { get; set; }

        public TrainView()
        {

        }
    }
}
