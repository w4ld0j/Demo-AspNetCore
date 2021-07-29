using Demo__AspNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
    public interface IWarehouseService
    {
        IList<Warehouse> GetWarehouses();
        bool CreateWarehouse();
    }
}
