using MvcPatternTest.Models;

namespace MvcPatternTest.Interfaces
{
    public interface ICarRepository
    {
        Task<List<Car>> GetCars();
        Task AddCar(Car model);
    }
}
