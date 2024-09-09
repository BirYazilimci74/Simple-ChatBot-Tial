using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatBot.API
{
    public class APIOperations
    {
        private readonly HttpClient _httpClient;
        string url = $"http://127.0.0.1:5000/get_response/";
        public APIOperations(HttpClient client)
        {
            _httpClient = client;
        }

        public async Task<string> GetResponseAsync(string query)
        {
            try
            {
                var response = await _httpClient.GetStringAsync(url + $"{Uri.EscapeDataString(query)}");
                var responseObject = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(response);
                return responseObject.response.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
