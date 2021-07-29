using Demo__AspNetCore;
using Microsoft.AspNetCore.Mvc.Testing;
using Newtonsoft.Json;
using System;
using System.Net;
using Xunit;
using Xunit.Abstractions;

namespace Test
{
    public class WarehouseTest
    {
        //Instalamos el paquete necesario para WebApplicationFactory

        //Interface de Xunit que nos sirve para hacer outputs de las pruebas
        private readonly ITestOutputHelper _outputHelper;
        //Instancia de startup --> instancia de todo el servicio
        private readonly WebApplicationFactory<Startup> _factory;

        public WarehouseTest(ITestOutputHelper outputhelper)
        {
            _factory = new WebApplicationFactory<Startup>();
            _outputHelper = outputhelper;
        }

        [Fact] //Atributo para marcar que es un metodo de prueba (testing)
        public async void TestGetWarehouses()
        {
            //1 Arrange --> Todo el codigo que se necesita organizar antes de hacer una prueba
                //Crear instacia del startup
            var client = _factory.CreateDefaultClient();
            
            //2 Act --> Acto o accion que queremos probar
            var response = await client.GetAsync("api/warehouse/GetWarehouses");
            
            //3 Assert --> Evaluar el resultado de la accion que ejecutamos
            Assert.NotNull(response);
            Assert.Equal(HttpStatusCode.OK , response.StatusCode);
                //Ver los resultados de la llamada del reponse
            var responseContent = response.Content.ReadAsStringAsync().Result;
            Assert.NotNull(responseContent);
            Assert.NotEmpty(responseContent);

            _outputHelper.WriteLine(JsonConvert.SerializeObject(responseContent));
        }
    }
}
