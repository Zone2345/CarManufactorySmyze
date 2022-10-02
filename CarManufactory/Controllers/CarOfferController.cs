using CarManufactory.Models;
using CarManufactory.Services;
using Microsoft.AspNetCore.Mvc;

namespace CarManufactory.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarOfferController : Controller
    {
        private readonly IGetCarOfferClientService _getCarOfferClientService;
        public CarOfferController(IGetCarOfferClientService getCarOfferClientService)
        {
            _getCarOfferClientService = getCarOfferClientService;
        }
        [HttpGet(Name = "GetCarOffer")]
        public async Task<Car> GetOffer(string name, string model, string color)
        {
            return await _getCarOfferClientService.GetCarOfferService(name, model, color);
        }
    }
}
