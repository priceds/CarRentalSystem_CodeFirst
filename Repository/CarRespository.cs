using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CarRespository : ICarRepository
    {

        private readonly CarRentalDbContext _context;
        public CarRespository(CarRentalDbContext context)
        {
            _context = context;
        }
        public int AddCar(Car car)
        {
            _context.Cars.Add(car);
            _context.SaveChanges();
             return 1;
        }

        public int DeleteCar(int id)
        {
            var CarInDb = _context.Cars.Where(car => car.CarId == id).SingleOrDefault();
            _context.Cars.Remove(CarInDb);
            _context.SaveChanges();
            return 1;
        }

        public async Task<IEnumerable<Car>> GetAllCars()
        {
            return await _context.Cars.ToListAsync();
        }

        public async Task<IEnumerable<Car>> GetOnlyFreeCars()
        {
            var list = await (from car in _context.Cars where car.CarId != 
                              (from booking in _context.Bookings where booking.JourneyCompletion == "OnGoing" 
                               select booking.CarId).First() select car).ToListAsync();

            return list;
        }

        public int UpdateCar(Car car)
        {
            var CarInDb = _context.Cars.Where(car => car.CarId == car.CarId).SingleOrDefault();
            CarInDb.CarModel = car.CarModel;
            CarInDb.CarRtoNumber = car.CarRtoNumber;
            CarInDb.CarType = car.CarType;
            CarInDb.CarMileage = car.CarMileage;
            CarInDb.CarPersonCapacity = car.CarPersonCapacity;
            CarInDb.CarCondition = car.CarCondition;
            CarInDb.KmDone = car.KmDone;
            CarInDb.FuelType = car.FuelType;
            CarInDb.RentPerKm = car.RentPerKm;
            CarInDb.ReviewId = car.ReviewId;
            CarInDb.InService = car.InService;
            _context.SaveChanges();
            return 1;
        }
    }
}
