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

        public static Gender GetGenderByName(string nom)
        {
            Gender la = null;
            try
            {
                la = (Gender)MakeRequest("gender/" + nom, "GET", null, typeof(Gender)).Result;
            }
            catch { }
            if (la == null)
            {
                la = new Gender();
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
   
                u = (User)MakeRequest("users/", "POST", user, typeof(User)).Result;
            
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

            s = (Sport)MakeRequest("sport/", "POST", sport, typeof(Sport)).Result;

            if (s == null)
            {
                s = new Sport();
            }
            return s;
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

