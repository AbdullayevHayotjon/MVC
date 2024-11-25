using MvcPatternTest.Entities;
using MvcPatternTest.Interfaces;
using MvcPatternTest.Models;

namespace MvcPatternTest.Repositories
{
    public class CarRepository : ICarRepository
    {
        private EntityContext _entityContext;
        public CarRepository(EntityContext entityContext)
        {
            _entityContext = entityContext;
        }

        public async Task AddCar(Car model)
        {
            _entityContext.Cars.Add(model);
            _entityContext.SaveChanges();
        }

        public Task<List<Car>> GetCars()
        {
            throw new NotImplementedException();
        }
    }
}
