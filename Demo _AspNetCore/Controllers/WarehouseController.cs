using Demo__AspNetCore.Models;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demo__AspNetCore.Controllers
{
    [ApiController] //Atributte
    [Route("api/[controller]")] //Route //[controller] hace referencia a el controlador actual
    public class WarehouseController : Controller
    {
        //Inyeccion de dependencias
        /*IWarehouseService _warehouseService;
        public WarehouseController(IWarehouseService warehouseService)
        {
            _warehouseService = warehouseService;
        }*/
        //localhost:*puerto*/api/warehouse/getwarehouse --> Acceder al endpoint
        [HttpGet("GetWarehouses")] //Nombre de la accion
        public IActionResult GetWarehouse([FromServices] IWarehouseService _warehouseService) //Inyeccion de dependicas a endpoint (parametro)
        {
            return Ok(_warehouseService.GetWarehouses());
        }
        //localhost:*port*/api/warehouse/GetWarehouseFromQuery
        //By default query string its being used
        //[Querystring] = localhost:*port*/api/warehouse/GetWarehouseFromQuery?userId=1
        [HttpGet("GetWarehouseFromQuery")]
        public IActionResult GetWarehouseFromQuery(
        [FromQuery] int warehouseId,
        [FromQuery] string warehouseName)
        {
            return Ok($"Hello whorehouse id {warehouseId}, and whorehouse name {warehouseName}");
        }
        //From Route
        //https://localhost:*port*/api/warehouse/getwarehousefromroute/number/name
        [HttpGet("GetWarehouseFromRoute/{warehouseId}/{warehouseName}")] //{parameter}
        public IActionResult GetWarehouseFromRoute(
        [FromRoute] int warehouseId,
        [FromRoute] string warehouseName)
        {
            return Ok($"Hello whorehouse id {warehouseId}, and whorehouse name {warehouseName}");
        }
        //From Body (post)
        [HttpPost("CreateWarehouse")]
        public IActionResult CreateWarehouse([FromBody] Warehouse warehouse)
        {
            return Ok($"Hello warehouse id {warehouse.Id}, and warehouse name {warehouse.Name}");
        }
    }
    
}
