using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Mabit.Models.Auth;
using Mabit.Services.Helper;
using Newtonsoft.Json;

namespace Mabit.Services.Auth
{
    public class AuthService
    {
        private readonly string baseUrl = "http://185.173.105.237:81/";
        public RequestTokenResult RequestToken(string userName,string password)
        {
           
            var getTokenUrl = baseUrl + "api/Auth/RequestToken";
            using (HttpClient httpClient = new HttpClient())
            {
                HttpContent content = new FormUrlEncodedContent(new[]
                {
                    //new KeyValuePair<string, string>("grant_type", "password"),
                    new KeyValuePair<string, string>("username", userName),
                    new KeyValuePair<string, string>("password", password)
                });
                HttpResponseMessage result = httpClient.PostAsync(getTokenUrl, content).Result;

                string resultContent = result.Content.ReadAsStringAsync().Result;

                return JsonConvert.DeserializeObject<RequestTokenResult>(resultContent);
            }
        }
    }
}
