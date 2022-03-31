using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CarRentalDbContext:DbContext
    {
        public CarRentalDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Driver> Drivers { get; set; }
  
        public DbSet<DriverReview> DriverReviews { get; set; }
        public DbSet<CarReview>CarReviews { get; set; }
        public DbSet<JourneyCompletion>Journeys { get; set; }
        public DbSet<Receipt>Receipts { get; set; }
        public DbSet<TripReview>TripReviews { get; set; }

        
    }
}
