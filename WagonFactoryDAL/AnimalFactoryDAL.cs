using ContractLayer;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class AnimalFactoryDAL
    {
        public static IAnimalCollectionDAL CreateAnimalCollectionDAL()
        {
            return new AnimalDAL();
        }
    }
}
