using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface ICarRepository
    {
        int AddCar(Car car);
        int UpdateCar(Car car);
        int DeleteCar(int id);
        Task<IEnumerable<Car>> GetOnlyFreeCars();
        Task<IEnumerable<Car>> GetAllCars();

    }
}
