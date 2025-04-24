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
                BaseAddress = new Uri("http://172.16.24.24/municipis/")
            };
            httpClient.DefaultRequestHeaders.Add("Accept", contentType);
        }

        public static List<Ubicacio> GetUbicacio(double latitud, double longitud)
        {
            List<Ubicacio> la = null;
            try
            {
                la = (List<Ubicacio>)MakeRequest("?latitud="+ latitud + "&longitud="+longitud, "GET", null, typeof(List<Ubicacio>)).Result;
            }
            catch { }
            if (la == null)
            {
                la = new List<Ubicacio>();
            }
            return la;
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