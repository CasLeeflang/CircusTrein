using ContractLayer;
using DAL;
using System;

namespace Factory
{
    public class WagonFactoryDAL
    {
        public static IWagonCollectionDAL CreateWagonCollectionDAL()
        {
            return new WagonDAL();
        }
    }
}
