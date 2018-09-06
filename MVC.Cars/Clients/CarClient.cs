using FinalCapstone.Models;
using MVC.Cars.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace MVC.Cars.Clients
{
    public class CarClient
    {
        private readonly IRestClient _client;
        public CarClient()
        {
            _client = new RestClient(ConfigurationManager.AppSettings["CarApiBaseUrl"]);
        }
        public async Task<ICollection<Car>> GetCars()
        {
            var request = new RestRequest("api/CarsAPI", Method.GET);
            var response = await _client.ExecuteTaskAsync(request);
            return JsonConvert.DeserializeObject<ICollection<Car>>(response.Content);
        }
        public async Task<ICollection<Car>> GetColor(string color)
        {
            var request = new RestRequest("api/CarsAPI", Method.GET);
            var response = await _client.ExecuteTaskAsync(request);
            return JsonConvert.DeserializeObject<ICollection<Car>>(response.Content);
        }
        public async Task<ICollection<Car>> GetMake(string make)
        {
            var request = new RestRequest("api/CarsAPI", Method.GET);
            var response = await _client.ExecuteTaskAsync(request);
            return JsonConvert.DeserializeObject<ICollection<Car>>(response.Content);
        }
        public async Task<ICollection<Car>> GetModel(string model)
        {
            var request = new RestRequest("api/CarsAPI", Method.GET);
            var response = await _client.ExecuteTaskAsync(request);
            return JsonConvert.DeserializeObject<ICollection<Car>>(response.Content);
        }
        public async Task<ICollection<Car>> GetYear(int year)
        {
            var request = new RestRequest("api/CarsAPI", Method.GET);
            var response = await _client.ExecuteTaskAsync(request);
            return JsonConvert.DeserializeObject<ICollection<Car>>(response.Content);
        }
    }
}