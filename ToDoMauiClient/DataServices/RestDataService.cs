using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ToDoMauiClient.Models;

namespace ToDoMauiClient.DataServices
{
    public class RestDataService : IRestDataService
    {
        private readonly HttpClient _httpClient;
        private readonly string _baseAddress;
        private readonly string _url;
        private readonly JsonSerializerOptions _jsonSerializerOptioins;

        public RestDataService()
        {
            _httpClient = new HttpClient();
            _baseAddress = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:5130" : "https://localhost:7154";
            _url = $"{_baseAddress}/api";

            _jsonSerializerOptioins = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
        }


        public Task AddToDoAsync(ToDo toDo)
        {
            throw new NotImplementedException();
        }

        public Task DeleteToDoAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<ToDo>> GetAllToDosAsync()
        {
            throw new NotImplementedException();
        }

        public Task UpdateToDoAsync(ToDo toDo)
        {
            throw new NotImplementedException();
        }
    }
}
