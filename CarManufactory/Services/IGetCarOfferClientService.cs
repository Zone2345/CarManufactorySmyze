using CarManufactory.Models;

namespace CarManufactory.Services
{
    public interface IGetCarOfferClientService
    {
        Task<Car> GetCarOfferService(string name, string model, string color);
    }
}
