using Mabit.Models.Auth;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
    
namespace Mabit.Services.Helper
{
    public static class HttpHelper
    {

        private static readonly string apiBasicUri = "http://185.173.105.237:81/";
        

        public static RequestTokenResult RequestToken(RequestTokenModel model)
        {
            using (var client = new WebClient())
            {
                client.Headers.Add("Content-Type:application/json");
                var encodedJson = JsonConvert.SerializeObject(model);
                var response = client.UploadString(apiBasicUri+"api/Auth/RequestToken", encodedJson);
                return JsonConvert.DeserializeObject<RequestTokenResult>(response);
            }
        }
        public static async Task Post<T>(string url, string culture, T contentValue)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBasicUri);
                client.DefaultRequestHeaders.Add("lang", culture);
                var content = new StringContent(JsonConvert.SerializeObject(contentValue), Encoding.UTF8, "application/json");
                var result = await client.PostAsync(apiBasicUri+ url, content);
                result.EnsureSuccessStatusCode();
            }
        }
        public static async Task<T> Post<T,T1>(string url, string culture, T1 contentValue)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBasicUri);
                client.DefaultRequestHeaders.Add("lang", culture);
                var content = new StringContent(JsonConvert.SerializeObject(contentValue), Encoding.UTF8, "application/json");
                var result = await client.PostAsync(apiBasicUri + url, content);
                result.EnsureSuccessStatusCode();
                string resultContentString = await result.Content.ReadAsStringAsync();
                T resultContent = JsonConvert.DeserializeObject<T>(resultContentString);
                return resultContent;
            }
        }


        public static async Task Put<T>(string url, T stringValue)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBasicUri);
                var content = new StringContent(JsonConvert.SerializeObject(stringValue), Encoding.UTF8, "application/json");
                var result = await client.PutAsync(url, content);
                result.EnsureSuccessStatusCode();
            }
        }
        public static async Task<List<T>> GetAllTopRom<T>(string url, string culture = "fa")
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBasicUri);
                client.DefaultRequestHeaders.Add("lang", culture);
                var result = await client.PostAsync(url, null);
                result.EnsureSuccessStatusCode();
                string resultContentString = await result.Content.ReadAsStringAsync();
                List<T> resultContent = JsonConvert.DeserializeObject<List<T>>(resultContentString);
                return resultContent;
            }
        }
        public static async Task<List<T>> GetAll<T>(string url,string culture="fa")
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBasicUri);
                client.DefaultRequestHeaders.Add("lang", culture);
                var result = await client.GetAsync(url);
                result.EnsureSuccessStatusCode();
                string resultContentString = await result.Content.ReadAsStringAsync();
                List<T> resultContent = JsonConvert.DeserializeObject<List<T>>(resultContentString);
                return resultContent;
            }
        }
        public static async Task<List<T>> GetAll<T,T1>(string url,T1 contentValue, string culture = "fa")
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBasicUri);
                client.DefaultRequestHeaders.Add("lang", culture);
                var content = new StringContent(JsonConvert.SerializeObject(contentValue), Encoding.UTF8, "application/json");
                var result = await client.PostAsync(url, content);
                result.EnsureSuccessStatusCode();
                string resultContentString = await result.Content.ReadAsStringAsync();
                List<T> resultContent = JsonConvert.DeserializeObject<List<T>>(resultContentString);
                return resultContent;
            }
        }
        public static async Task<T> GetReservationRooms<T, T1>(string url, T1 contentValue, string culture = "fa")
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBasicUri);
                client.DefaultRequestHeaders.Add("lang", culture);
                var content = new StringContent(JsonConvert.SerializeObject(contentValue), Encoding.UTF8, "application/json");
                var result = await client.PostAsync(url, content);
                result.EnsureSuccessStatusCode();
                string resultContentString = await result.Content.ReadAsStringAsync();
                T resultContent = JsonConvert.DeserializeObject<T>(resultContentString);
                return resultContent;
            }
        }
        public static async Task<T> Get<T>(string url)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBasicUri);
                var result = await client.GetAsync(url);
                result.EnsureSuccessStatusCode();
                string resultContentString = await result.Content.ReadAsStringAsync();
                T resultContent = JsonConvert.DeserializeObject<T>(resultContentString);
                return resultContent;
            }
        }
               
        public static async Task Delete(string url)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBasicUri);
                var result = await client.DeleteAsync(url);
                result.EnsureSuccessStatusCode();
            }
        }
    }
}
