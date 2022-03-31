using Entities.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CarService : ICarService
    {
        private readonly ICarRepository _carRepository;
        public CarService(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public int AddCar(Car car)
        {
            _carRepository.AddCar(car);
        }

        public int DeleteCar(int id)
        {
           return _carRepository.DeleteCar(id);
        }

        public Task<IEnumerable<Car>> GetAllCars()
        {
            return _carRepository.GetAllCars();
        }

        public Task<IEnumerable<Car>> GetOnlyFreeCars()
        {
            return _carRepository.GetOnlyFreeCars();
        }

        public int UpdateCar(Car car)
        {
            return _carRepository.UpdateCar(car);
        }
    }
}
