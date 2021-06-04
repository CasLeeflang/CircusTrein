using DTOs;
using System;
using System.Collections.Generic;

namespace ContractLayer
{
    public interface IWagonCollectionDAL
    {
        void ClearWagons();
        IEnumerable<WagonDTO> GetWagons();
        void AddWagon(WagonDTO wagonDTO);
    }
}
