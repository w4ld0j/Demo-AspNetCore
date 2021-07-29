using Demo__AspNetCore.Models;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    //Servicio Logico
    public class WarehouseService : IWarehouseService
    {
        public bool CreateWarehouse()
        {
            throw new NotImplementedException();
        }

        public IList<Warehouse> GetWarehouses()
        {
            return new List<Warehouse>()
            {
                new Warehouse() {Id = 1, Name = "Warehouse1"},
                new Warehouse() {Id = 2, Name = "Warehouse2"},
                new Warehouse() {Id = 3, Name = "Warehouse3"}
            };
        }
    }
}
