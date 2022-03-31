using Entities.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class DriverService:IDriverService
    {
        private readonly IDriverRepository _driverRepository;
        public DriverService(IDriverRepository driverRepository)
        {
            _driverRepository = driverRepository;
        }

        public int AddDriver(Driver driver)
        {
            return _driverRepository.AddDriver(driver);
        }

        public Task<Driver> CheckIfDriverisValid(string email, string password)
        {
            return _driverRepository.CheckIfDriverisValid(email, password);
        }

        public int DeleteDriver(int id)
        {
            return _driverRepository.DeleteDriver(id);
        }

        public Task<IEnumerable<Driver>> GetAllDrivers()
        {
            return _driverRepository.GetAllDrivers();
        }

        public Task<IEnumerable<Driver>> GetOnlyFreeDrivers()
        {
            return _driverRepository.GetOnlyFreeDrivers();
        }

        public int UpdateDriver(Driver driver)
        {
            return _driverRepository.UpdateDriver(driver);
        }
    }

}
