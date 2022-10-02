using CarManufactory.Models;
using System.Collections.Specialized;
using System.Data;
using System.Text.Json;
using System.Web;

namespace CarManufactory.Services
{
    public class GetOfferService : IGetCarOfferClientService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public GetOfferService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<Car> GetCarOfferService(string name, string model, string color)
        {
            Car result = new Car();
            try
            {
                var response = await _httpClient.GetAsync($"?name={name}&model={model}&color={color}");
                if (response.IsSuccessStatusCode)
                {
                    var jsonResult = await response.Content.ReadAsStringAsync();
                    result = JsonSerializer.Deserialize<Car>(jsonResult);
                }
                
            }catch(Exception e)
            {
                throw;
            }
            

            return result;
        }

    }
}
