using Newtonsoft.Json;
using SportXperience.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

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
                BaseAddress = new Uri("https://localhost:7161/api/")
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

        public static List<Event> GetEventbyUserDNI(string dni)
        {
            List<Event> la = null;
            try
            {
                la = (List<Event>)MakeRequest("events/" + dni, "GET", null, typeof(List<Event>)).Result;
            }
            catch { }
            if (la == null)
            {
                la = new List<Event>();
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

