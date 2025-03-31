using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DesktopModels.Model
{
    public class Repositori
    {
        static HttpClient httpClient;

        static readonly string ErrorMessage = "Error en l'API.";
        static readonly string contentType = "application/json";

        public static void CreateHttpClient()  // Cal executar aquest mètode en el constructor del Controller
        {
            httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7101/api/")
            };
            httpClient.DefaultRequestHeaders.Add("Accept", contentType);
        }
    }
}
