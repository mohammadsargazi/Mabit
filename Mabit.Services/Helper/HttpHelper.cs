using Mabit.Models.Auth;
using Mabit.Models.Model.Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Internal;
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
                var response = client.UploadString(apiBasicUri + "api/Auth/RequestToken", encodedJson);
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
                var result = await client.PostAsync(apiBasicUri + url, content);
                result.EnsureSuccessStatusCode();
            }
        }
        public static async Task<T> Post<T, T1>(string url, string culture, T1 contentValue)
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
        public static async Task<int> UploadBase64(string url, FileUploadModel file)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBasicUri);
                var content = new StringContent(JsonConvert.SerializeObject(file), Encoding.UTF8, "application/json");
                var result = await client.PostAsync(apiBasicUri + url, content);
                result.EnsureSuccessStatusCode();
                string resultContentString = await result.Content.ReadAsStringAsync();
                var resultContent = JsonConvert.DeserializeObject<FileUploadResult>(resultContentString);
                return resultContent.id;
            }
        }
        public static async Task<int> Upload(string url, string culture, IList<IFormFile> files)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBasicUri);
                //client.DefaultRequestHeaders.Add("lang", culture);
                string boundary = $"{Guid.NewGuid().ToString()}";
                MultipartFormDataContent requestContent = new MultipartFormDataContent(boundary);
                requestContent.Headers.Remove("Content-Type");
                // The two dashes in front of the boundary are important as the framework includes them when serializing the request content.
                requestContent.Headers.TryAddWithoutValidation("Content-Type", $"multipart/form-data; boundary=--{boundary}");
                foreach (IFormFile file in files)
                {
                    StreamContent streamContent = new StreamContent(file.OpenReadStream());
                    requestContent.Add(streamContent, file.Name, file.FileName);
                    streamContent.Headers.ContentDisposition.FileNameStar = "";
                }
                var result = await client.PostAsync(apiBasicUri + url, requestContent);
                //result.EnsureSuccessStatusCode();
                string resultContentString = await result.Content.ReadAsStringAsync();
                int resultContent = JsonConvert.DeserializeObject<int>(resultContentString);
                return resultContent;
            }
        }
        //public async Task PostAttachmentAsync(int ticketID, IFormFileCollection files, CancellationToken cancellationToken = default)
        //{
        //    using (HttpRequestMessage request = new HttpRequestMessage())
        //    {
        //        string boundary = $"{Guid.NewGuid().ToString()}";
        //        MultipartFormDataContent requestContent = new MultipartFormDataContent(boundary);
        //        requestContent.Headers.Remove("Content-Type");
        //        // The two dashes in front of the boundary are important as the framework includes them when serializing the request content.
        //        requestContent.Headers.TryAddWithoutValidation("Content-Type", $"multipart/form-data; boundary=--{boundary}");

        //        foreach (IFormFile file in files)
        //        {
        //            StreamContent streamContent = new StreamContent(file.OpenReadStream());
        //            requestContent.Add(streamContent, file.Name, file.FileName);
        //            streamContent.Headers.ContentDisposition.FileNameStar = "";
        //        }

        //        request.Content = requestContent;
        //        request.Method = new HttpMethod("POST");
        //        request.RequestUri = new Uri($"api/v3/Services/WorkItem/Ticket/Attachment?ticketID={ticketID}", UriKind.Relative);

        //        HttpClient client = await CreateHttpClientAsync(cancellationToken).ConfigureAwait(false);

        //        using (HttpResponseMessage response =
        //            await client.SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken).ConfigureAwait(false)
        //        )
        //        {
        //        }
        //    }
        //}
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
        public static async Task<List<T>> GetAll<T>(string url, string culture = "fa")
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
        public static async Task<List<T>> GetAll<T, T1>(string url, T1 contentValue, string culture = "fa")
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

        public static async Task<List<T>> GetAllWithAuthentication<T>(string url, string token, string culture = "fa")
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiBasicUri);
                client.DefaultRequestHeaders.Add("lang", culture);
                client.DefaultRequestHeaders.Add("token", token);
                var result = await client.PostAsync(url, null);
                result.EnsureSuccessStatusCode();
                string resultContentString = await result.Content.ReadAsStringAsync();
                List<T> resultContent = JsonConvert.DeserializeObject<List<T>>(resultContentString);
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
