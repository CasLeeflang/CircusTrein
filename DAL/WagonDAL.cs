using ContractLayer;
using DTOs;
using Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class WagonDAL : IWagonCollectionDAL
    {
        public void InitializeWagons(int length)
        {
            WagonStorage.CreateWagonList(length);
        }
        public void ClearWagons()
        {
            WagonStorage.ClearWagons();
        }

        public void AddWagon(WagonDTO wagonDTO)
        {
            WagonStorage.AddWagon(wagonDTO);
        }

        public IEnumerable<WagonDTO> GetWagons()
        {
            return WagonStorage.GetWagons();
        }
    }
}
