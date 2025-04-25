using Newtonsoft.Json;
using SportXperience.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopModels.Model
{
    public static class Repositori
    {
        static HttpClient httpClient;
        public static User usuari;

        static readonly string ErrorMessage = "Error en l'API.";
        static readonly string contentType = "application/json";

        public static void CreateHttpClient()  // Cal executar aquest mètode en el constructor del Controller
        {
            httpClient = new HttpClient
            {
                BaseAddress = new Uri("http://172.16.24.191:5097/api/")
            };
            httpClient.DefaultRequestHeaders.Add("Accept", contentType);
        }

        public static List<Gender> GetGender()
        {
            List<Gender> la = null;
            try
            {
                la = (List<Gender>)MakeRequest("gender/", "GET", null, typeof(List<Gender>)).Result;
            }
            catch { }
            if (la == null)
            {
                la = new List<Gender>();
            }
            return la;
        }

        public static Event GetEventMax()
        {
            Event la = null;
            try
            {
                la = (Event)MakeRequest("events/max", "GET", null, typeof(Event)).Result;
            }
            catch { }
            if (la == null)
            {
                la = new Event();
            }
            return la;
        }

        public static Ubication GetUbicationMax()
        {
            Ubication la = null;
            try
            {
                la = (Ubication)MakeRequest("ubications/max", "GET", null, typeof(Ubication)).Result;
            }
            catch { }
            if (la == null)
            {
                la = new Ubication();
            }
            return la;
        }

        public static User GetUserByDNI(string dni)
        {
            User la = null;
            try
            {
                la = (User)MakeRequest("users/dni/" + dni , "GET", null, typeof(User)).Result;
            }
            catch { }
            if (la == null)
            {
                la = new User();
            }
            return la;
        }

        public static User GetUserByMail(string mail)
        {
            User la = null;
            try
            {
                la = (User)MakeRequest("users/mail/" + mail, "GET", null, typeof(User)).Result;
            }
            catch { }
            if (la == null)
            {
                la = new User();
            }
            return la;
        }

        public static User GetUserByUsername(string username)
        {
            User la = null;
            try
            {
                la = (User)MakeRequest("users/username/" + username, "GET", null, typeof(User)).Result;
            }
            catch { }
            if (la == null)
            {
                la = new User();
            }
            return la;
        }
        public static User InsUser(User user)
        {
            User u = null;
            try
            {
                u = (User)MakeRequest("users/", "POST", user, typeof(User)).Result;
            }
            catch{ }
            if (u == null)
            {
                u = new User();
            }
            return u;
        }

        public static Ubication InsUbication(Ubication ubi)
        {
            Ubication u = null;
            try
            {
                u = (Ubication)MakeRequest("ubications/", "POST", ubi, typeof(Ubication)).Result;
            }
            catch { }
            if (u == null)
            {
                u = new Ubication();
            }
            return u;
        }

        public static User GetUserInici(string usernameOrMail, string password)
        {
            User la = null;
            try
            {
                la = (User)MakeRequest("users/" + usernameOrMail + "/" + password, "GET", null, typeof(User)).Result;
            }
            catch { }
            if (la == null)
            {
                la = new User();
            }
            return la;
        }

        public static List<RecommendedLevel> GetRecommendedLevel()
        {
            List<RecommendedLevel> la = null;
            try
            {
                la = (List<RecommendedLevel>)MakeRequest("recommendedLevel/", "GET", null, typeof(List<RecommendedLevel>)).Result;
            }
            catch { }
            if (la == null)
            {
                la = new List<RecommendedLevel>();
            }
            return la;
        }

        public static Sport InsSport(Sport sport)
        {
            Sport s = null;
            try
            {
                s = (Sport)MakeRequest("sports/", "POST", sport, typeof(Sport)).Result;
            }
            catch { }
            if (s == null)
            {
                s = new Sport();
            }
            return s;
        }

        public static Event InsEvents(Event events)
        {
            Event e = null;
            try
            {
                e = (Event)MakeRequest("events/", "POST", events, typeof(Event)).Result;
            }
            catch { }
            if (e == null)
            {
                e = new Event();
            }
            return e;
        }

        public static Sport GetSportByName(string nom)
        {
            Sport la = null;
            try
            {
                la = (Sport)MakeRequest("sports/" + nom, "GET", null, typeof(Sport)).Result;
            }
            catch { }
            if (la == null)
            {
                la = new Sport();
            }
            return la;
        }
        public static Ubication GetUbicationByLatitudLongitud(double latitud, double longitud)
        {
            Ubication la = null;
            try
            {
                la = (Ubication)MakeRequest("ubications/" + latitud + "/" + longitud, "GET", null, typeof(Ubication)).Result;
            }
            catch { }
            if (la == null)
            {
                la = new Ubication();
            }
            return la;
        }

        public static Participant InsParticipant(Participant participant)
        {
            Participant p = null;
            try
            {
                p = (Participant)MakeRequest("participants/", "POST", participant, typeof(Participant)).Result;
            }
            catch { }
            if (p == null)
            {
                p = new Participant();
            }
            return p;
        }

        public static List<EventDTO> GetEventbyUserDNI(string dni)
        {
            List<EventDTO> la = null;
            try
            {
                la = (List<EventDTO>)MakeRequest("events/" + dni, "GET", null, typeof(List<EventDTO>)).Result;
            }
            catch { }
            if (la == null)
            {
                la = new List<EventDTO>();
            }
            return la;
        }

        public static Lot InsLot(Lot lot)
        {
            Lot l = null;
            try
            {
                l = (Lot)MakeRequest("lots/", "POST", lot, typeof(Lot)).Result;
            }
            catch { }
            if (l == null)
            {
                l = new Lot();
            }
            return l;
        }

        public static Product InsProduct(Product product)
        {
            Product l = null;
            try
            {
                l = (Product)MakeRequest("products/", "POST", product, typeof(Product)).Result;
            }
            catch { }
            if (l == null)
            {
                l = new Product();
            }
            return l;
        }

        public static int GetLotMax()
        {
            int la = 0;
            try
            {
                la = (int)MakeRequest("lots/max", "GET", null, typeof(int)).Result;
            }
            catch { }
            
            return la;
        }

        public static Option InsOptions(Option option)
        {
            Option l = null;
            try
            {
                l = (Option)MakeRequest("options/", "POST", option, typeof(Option)).Result;
            }
            catch { }
            if (l == null)
            {
                l = new Option();
            }
            return l;
        }

        public static Product GetProductsByLotIdAndName(int idLot,string nom)
        {
            Product la = null;
            try
            {
                la = (Product)MakeRequest("products/"+ idLot +"/" + nom, "GET", null, typeof(Product)).Result;
            }
            catch { }
            if (la == null)
            {
                la = new Product();
            }
            return la;
        }

        public static List<Product> GetProductsByLotId(int idLot)
        {
            List<Product> la = null;
            try
            {
                la = (List<Product>)MakeRequest("products/lots/" + idLot, "GET", null, typeof(List<Product>)).Result;
            }
            catch { }
            if (la == null)
            {
                la = new List<Product>();
            }
            return la;
        }

        public static List<Option> GetOptionsByProductId(int productId)
        {
            List<Option> la = null;
            try
            {
                la = (List<Option>)MakeRequest("options/products/" + productId, "GET", null, typeof(List<Option>)).Result;
            }
            catch { }
            if (la == null)
            {
                la = new List<Option>();
            }
            return la;
        }

        public static void DelEvent(Event ev)
        {
            int id = ev.EventId;
            Event e = null;
            try
            {
                e = (Event)MakeRequest("events/all/" + id, "DELETE", ev, typeof(Event)).Result;
            }
            catch
            {
                if (e == null)
                {
                    e = new Event();
                }
            }

        }

        public static void DelLot(Lot l)
        {
            int id = l.LotId;
            Lot lo = null;
            try
            {
                lo = (Lot)MakeRequest("lots/" + id, "DELETE", l, typeof(Lot)).Result;
            }
            catch
            {
                if (lo == null)
                {
                    lo = new Lot();
                }
            }

        }

        public static void UpdEvent(Event ev)
        {
            Event e = null;
            try
            {
                e = (Event)MakeRequest("events/" + ev.EventId, "PUT", ev, typeof(Event)).Result;
            }
            catch
            {
                if (e == null)
                {
                    e = new Event();
                }
            }

        }

        public static RecommendedLevel GetRecommendedLevelById(int? id)
        {
            RecommendedLevel la = null;
            try
            {
                la = (RecommendedLevel)MakeRequest("recommendedLevel/" + id, "GET", null, typeof(RecommendedLevel)).Result;
            }
            catch { }
            if (la == null)
            {
                la = new RecommendedLevel();
            }
            return la;
        }
        public static Sport GetSportById(int? id)
        {
            Sport la = null;
            try
            {
                la = (Sport)MakeRequest("sports/" + id, "GET", null, typeof(Sport)).Result;
            }
            catch { }
            if (la == null)
            {
                la = new Sport();
            }
            return la;
        }

        public static Ubication GetUbicationById(int? id)
        {
            Ubication la = null;
            try
            {
                la = (Ubication)MakeRequest("ubications/" + id, "GET", null, typeof(Ubication)).Result;
            }
            catch { }
            if (la == null)
            {
                la = new Ubication();
            }
            return la;
        }

        public static Lot GetLotByEventId(int? id)
        {
            Lot la = null;
            try
            {
                la = (Lot)MakeRequest("lots/" + id, "GET", null, typeof(Lot)).Result;
            }
            catch { }
            if (la == null)
            {
                la = new Lot();
            }
            return la;
        }

        public static Event GetEventById(int Id)
        {
            Event la = null;
            try
            {
                la = (Event)MakeRequest("events/" + Id, "GET", null, typeof(Event)).Result;
            }
            catch { }
            if (la == null)
            {
                la = new Event();
            }
            return la;
        }

        public static async Task<string> PostImageEvent(string rutaImagen)
        {
            try
            {
                if (string.IsNullOrEmpty(rutaImagen) || !File.Exists(rutaImagen))
                    throw new Exception("Ruta de imagen inválida.");

                using (var cliente = new HttpClient())
                using (var imagenStream = File.OpenRead(rutaImagen))
                using (var contenido = new MultipartFormDataContent())
                {
                    var archivo = new StreamContent(imagenStream);
                    archivo.Headers.ContentType = new MediaTypeHeaderValue("image/jpeg");

                    contenido.Add(archivo, "imagen", Path.GetFileName(rutaImagen));

                    string url = "https://localhost:7161/api/events/image";
                    var response = await cliente.PostAsync(url, contenido);

                    response.EnsureSuccessStatusCode();

                    string json = await response.Content.ReadAsStringAsync();
                    dynamic data = JsonConvert.DeserializeObject(json);
                    return data.url;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error subiendo imagen: " + ex.Message);
                return null;
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

            if (method == "DELETE")
            {
                response = httpClient.DeleteAsync(url).Result;
                if (response.IsSuccessStatusCode)
                {
                    return null;
                }
                else
                {
                    throw new Exception(ErrorMessage);
                }
            }
            else if (method == "GET")
            {
                response = httpClient.GetAsync(url).Result;
            }
            else if (method == "POST" || method == "PUT")
            {
                var objectJson = JsonConvert.SerializeObject(JSONcontent);
                var content = new StringContent(objectJson, Encoding.UTF8, contentType);


                if (method == "POST")
                {
                    response = httpClient.PostAsync(url, content).Result;
                }
                else
                {
                    response = httpClient.PutAsync(url, content).Result;
                }
            }
            else
            {
                return null;
            }

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

