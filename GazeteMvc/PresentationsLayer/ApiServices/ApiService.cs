﻿
using Microsoft.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace PresentationsLayer.ApiServices
{
    public class ApiService : IApiService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public ApiService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<bool> DeleteData(string endPoint, string token = null)
        {
            var baseAddress = "http://localhost:5013/api/";
            var client = _httpClientFactory.CreateClient();

            var requestMessage = new HttpRequestMessage()
            {
                Method = HttpMethod.Delete,
                RequestUri = new Uri($"{baseAddress}{endPoint}"),
                Headers = { { HeaderNames.Accept, "appliication/json" } }
            };
            var responseMessage = await client.SendAsync(requestMessage);
            return responseMessage.IsSuccessStatusCode;
        }

        public async Task<T> GetData<T>(string endPoint, string token = null)
        {
            var baseAddress = "http://localhost:5013/api/";
            var client = _httpClientFactory.CreateClient();
            var requestMessage = new HttpRequestMessage()
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri($"{baseAddress}{endPoint}"),
                Headers = { { HeaderNames.Accept, "application/json" } }
            };
            var responseMessage = await client.SendAsync(requestMessage);
            var jsonResponse = await responseMessage.Content.ReadAsStringAsync();
            var responseObject = JsonSerializer.Deserialize<T>(jsonResponse, new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = true
            });
            return responseObject;
        }

        public async Task<bool> PostData(string endPoint, string jsonData, string token = null)
        {
            var baseAddress = "http://localhost:5013/api/";
            var client = _httpClientFactory.CreateClient();
            var requestMessage = new HttpRequestMessage()
            {
                Method = HttpMethod.Post,
                RequestUri = new Uri($"{baseAddress}{endPoint}"),
                Headers = { { HeaderNames.Accept, "application/json" } },
                Content = new StringContent(jsonData, Encoding.UTF8, "application/json")
            };
            var responseMessage = await client.SendAsync(requestMessage);
            if (!responseMessage.IsSuccessStatusCode)
            {
                var errorContent = await responseMessage.Content.ReadAsStringAsync();
                //Console.WriteLine($"Error: {responseMessage.StatusCode}, Content: {errorContent}");
            }
            return responseMessage.IsSuccessStatusCode;
        }

        public async Task<bool> PutData(string endPoint, string jsonData, string token = null)
        {
            var baseAddress = "http://localhost:5013/api/";
            var client = _httpClientFactory.CreateClient();

            var requestMessage = new HttpRequestMessage()
            {
                Method = HttpMethod.Put,
                RequestUri = new Uri($"{baseAddress}{endPoint}"),
                Headers = { { HeaderNames.Accept, "application/json" } },
                Content = new StringContent(jsonData, Encoding.UTF8, "application/json")
            };

            var responseMessage = await client.SendAsync(requestMessage);

            return responseMessage.IsSuccessStatusCode;
        }
    }
}