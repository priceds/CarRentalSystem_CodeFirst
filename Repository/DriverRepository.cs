using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class DriverRepository : IDriverRepository
    {
        private readonly CarRentalDbContext _context;
        public DriverRepository(CarRentalDbContext context)
        {
            _context = context;
        }
        public int AddDriver(Driver driver)
        {
            _context.Drivers.Add(driver);
            _context.SaveChanges();
            return 1;
        }

        public async Task<Driver> CheckIfDriverisValid(string email, string password)
        {
            return await _context.Drivers.Where(driver => driver.DriverEmail == email && driver.DriverPassword == password).SingleOrDefaultAsync();
        }

        public int DeleteDriver(int id)
        {
            var DriverInDb = _context.Drivers.Find(id);
            _context.Drivers.Remove(DriverInDb);
            _context.SaveChanges();
            return 1;
        }

        public async Task<IEnumerable<Driver>> GetAllDrivers()
        {
            return await _context.Drivers.ToListAsync();
        }

        public async Task<IEnumerable<Driver>> GetOnlyFreeDrivers()
        {
            var DriversNotOnDuty = await (from d in _context.Drivers
                             where d.DriverId != (from b in _context.Bookings
                                                  where b.JourneyCompletion == "OnGoing"
                                                  select b.DriverId).First()
                             select d).ToListAsync();
            return DriversNotOnDuty;
        }

        public int UpdateDriver(Driver driver)
        {
            var DriverInDb = _context.Drivers.Where(driver => driver.DriverId == driver.DriverId).SingleOrDefault();
            DriverInDb.DriverName = driver.DriverName;
            DriverInDb.DriverLicensenumber = driver.DriverLicensenumber;
            DriverInDb.DriverPassword = driver.DriverPassword;
            DriverInDb.DriverPhone = driver.DriverPhone;
            DriverInDb.DriverAddress = driver.DriverAddress;
            DriverInDb.AnyAddiction = driver.AnyAddiction;
            DriverInDb.DriverAge = driver.DriverAge;
            DriverInDb.ReviewId = driver.ReviewId;
            DriverInDb.InService = driver.InService;
            DriverInDb.IsActive = driver.IsActive;
            _context.SaveChanges();
            return 1;
        }
    }
}
