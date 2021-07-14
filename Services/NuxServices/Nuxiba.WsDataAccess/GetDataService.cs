using Newtonsoft.Json;
using Nuxiba.Services.Entity;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;

namespace Nuxiba.Services.WsDataAccess
{
    public class GetDataService
    {

        public List<User> GetUsers(string urlService)
        {
            var result = new List<User>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(urlService);
                var response = client.GetAsync("users").GetAwaiter().GetResult();
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {

                    result = JsonConvert.DeserializeObject<List<User>>(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());
                }
            }

            return result;
        }

        public List<Post> GetUserPosts(string urlService, string idUser)
        {
            var result = new List<Post>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(urlService);
                var response = client.GetAsync($"users/{idUser}/posts").GetAwaiter().GetResult();
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    result = JsonConvert.DeserializeObject<List<Post>>(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());
                }
            }

            return result;
        }
        public List<Task> GetUserTasks(string urlService, string idUser)
        {
            var result = new List<Task>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(urlService);
                var response = client.GetAsync($"users/{idUser}/todos").GetAwaiter().GetResult();
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    result = JsonConvert.DeserializeObject<List<Task>>(response.Content.ReadAsStringAsync().GetAwaiter().GetResult());
                }
            }

            return result;
        }
        public string GetSaveData(string urlService, Task data)
        {
            var result = string.Empty;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(urlService);
                HttpContent httpContent = new StringContent(JsonConvert.SerializeObject(data), Encoding.UTF8);
                var response = client.PostAsync($"users/{data.UserId}/todos", httpContent).GetAwaiter().GetResult();
                if (response.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    result = response.StatusCode.ToString();
                }
            }

            return result;
        }
    }
}
