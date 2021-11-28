using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Channels;
using System.Threading.Tasks;
using Entities;

namespace A1.Networking
{
    public class Client : IClient
    {
        private string uri = "https://localhost:5003/";

        public async Task<IList<Adult>> ReadData()
        {
            using HttpClient client = new HttpClient();
            Console.WriteLine("Er vi her?");
            HttpResponseMessage responseMessage = await client.GetAsync(uri + "Adult");
            
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            string result = await responseMessage.Content.ReadAsStringAsync();

            IList<Adult> adultList = JsonSerializer.Deserialize<IList<Adult>>(result, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            return adultList;
        }

        public async Task SaveChanges(IList<Adult> adults)
        {
            using HttpClient client = new HttpClient();
            
            string adultListAsJson = JsonSerializer.Serialize(adults);

            StringContent content = new StringContent(adultListAsJson, Encoding.UTF8, "application/json");

            HttpResponseMessage responseMessage = await client.PostAsync(uri + "Adult", content);
            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }
        }
        
        public async Task<IList<User>> GetUsers()
        {
            using HttpClient client = new HttpClient();
           
            HttpResponseMessage responseMessage = await client.GetAsync(uri + "User");

            if (!responseMessage.IsSuccessStatusCode)
            {
                throw new Exception($@"Error: {responseMessage.StatusCode}, {responseMessage.ReasonPhrase}");
            }

            string result = await responseMessage.Content.ReadAsStringAsync();

            IList<User> userList = JsonSerializer.Deserialize<IList<User>>(result, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });

            Console.WriteLine(userList);
            return userList;
        }
    }
}