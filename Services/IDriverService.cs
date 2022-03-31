using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IDriverService
    {
        int AddDriver(Driver driver);
        int UpdateDriver(Driver driver);
        int DeleteDriver(int id);

        Task<Driver> CheckIfDriverisValid(string email, string password);
        Task<IEnumerable<Driver>> GetOnlyFreeDrivers();
        Task<IEnumerable<Driver>> GetAllDrivers();
    }
}
