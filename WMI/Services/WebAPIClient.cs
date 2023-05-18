using System;
using System.Management;
using System.Collections.Generic;
using WMI.Model;
using WMI.Services;
using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace WMI.Services
{
    public class WebAPIClient : IClient
    {
        public async Task<string> sendPost(string jsonString)
        {
            StringContent data = new StringContent(jsonString, Encoding.UTF8, "application/json");
            string url = "https://httpbin.org/post";
            using var client = new HttpClient();
            var response = await client.PostAsync(url, data);
            string result = await response.Content.ReadAsStringAsync();            
            return result;
        }
    }
}
