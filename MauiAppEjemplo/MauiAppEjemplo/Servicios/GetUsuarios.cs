using MauiAppEjemplo.Modelo;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace MauiAppEjemplo.Servicios
{
    public class GetUsuarios : IGetUsuarios
    {
        private string urlApi = "https://localhost:7139/api/UsuariosRest";
        public async Task<List<UsuariosResponse>> Obtener()
        {
            var client = new HttpClient();
            var response = await client.GetAsync(urlApi);
            var responseBody = await response.Content.ReadAsStringAsync();
            JsonNode nodos = JsonNode.Parse(responseBody);
            //JsonNode results = nodos["results"];
            var UsuariosData = JsonSerializer.Deserialize<List<UsuariosResponse>>(nodos.ToString());
            return UsuariosData;
        }
    }
}
