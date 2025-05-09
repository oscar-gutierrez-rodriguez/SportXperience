using Newtonsoft.Json;
using SportXperience.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace DesktopModels.Model
{
    public class RepositoriUbicacions
    {
        static HttpClient httpClient;
        public static User usuari;

        static readonly string ErrorMessage = "Error en l'API.";
        static readonly string contentType = "application/json";

        public static void CreateHttpClient()  // Cal executar aquest mètode en el constructor del Controller
        {
            httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://172.16.24.164/municipis/")
            };
            httpClient.DefaultRequestHeaders.Add("Accept", contentType);
        }

        public static async Task<List<Ubicacio>> GetUbicacio(double latitud, double longitud)
        {
            try
            {
                string url = $"?latitud={latitud.ToString(System.Globalization.CultureInfo.InvariantCulture)}&longitud={longitud.ToString(System.Globalization.CultureInfo.InvariantCulture)}";
                string json = await httpClient.GetStringAsync(url);

                Console.WriteLine("JSON recibido:");
                Console.WriteLine(json);

                List<Ubicacio> ubicacions = JsonConvert.DeserializeObject<List<Ubicacio>>(json);
                return ubicacions ?? new List<Ubicacio>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener ubicaciones: {ex.Message}");
                return new List<Ubicacio>();
            }
        }

        public static async Task<object> MakeRequest(string url, string method, object JSONcontent, Type responseType)
        ////  url: Url a partir de la base 
        ////  method: "GET"/"POST"/"PUT"/"DELETE"
        ////  JSONcontent: objecte que se li passa en el body 
        ////  responseType:  tipus d'objecte que torna el Web Service (=typeof(tipus))

        ////  contentType: "application/json" en els casos que el Web Service torni objectes
        {
            HttpResponseMessage response;
            
            response = httpClient.GetAsync(url).Result;
            

            if (response.IsSuccessStatusCode)
            {
                string json = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject(json, responseType);
                return result;
            }
            else
            {
                throw new Exception(ErrorMessage);
            }
        }
    }
}