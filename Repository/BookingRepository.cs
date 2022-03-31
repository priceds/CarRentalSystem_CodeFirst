using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class BookingRepository : IBookingRepository
    {
        private readonly CarRentalDbContext _context;
        public BookingRepository(CarRentalDbContext context)
        {
            _context = context;
        }
        public int AddBooking(Booking booking)
        {
            _context.Bookings.Add(booking);
            _context.SaveChanges();
            return 1;
        }

        public int DeleteBooking(int id)
        {
            var booking = _context.Bookings.Where(booking => booking.BookingId == id).SingleOrDefault();
            _context.Bookings.Remove(booking);
            _context.SaveChanges();
            return 1;
        }

        public async Task<IEnumerable<Booking>> GetAllBookingForCustomerWithId(int id)
        {
            return await _context.Bookings.Where(bookings => bookings.CustomerId == id).ToListAsync();


        }

        public async Task<IEnumerable<Booking>> GetAllBookings()
        {
            return await _context.Bookings.ToListAsync();
        }

        public async Task<IEnumerable<Booking>> GetAllConfirmedBookings()
        {
            return await _context.Bookings.Where(booking => booking.BookingStatus == "Confirmed").ToListAsync();
        }

        public async Task<IEnumerable<Booking>> GetAllJourneyCompletedBookings()
        {
            return await _context.Bookings.Where(booking => booking.JourneyCompletion == "Completed").ToListAsync();
        }

        public async Task<IEnumerable<Booking>> GetAllPaymentCompletedBookings()
        {
            return await _context.Bookings.Where(booking => booking.PaymentStatus == "Completed").ToListAsync();
        }

        public async Task<IEnumerable<Booking>> GetAllPendingBookings()
        {
            return await _context.Bookings.Where(booking => booking.BookingStatus == "Pending").ToListAsync();
        }

        public async Task<IEnumerable<Booking>> GetPastMonthBookings()
        {
            var dateCriteria = DateTime.Now.Date.AddMonths(-1);

            return await _context.Bookings.Where(booking => booking.CreatedOn >= dateCriteria).ToListAsync();
        }

        public async Task<IEnumerable<Booking>> GetPastSixMonthBookings()
        {
            var dateCriteria = DateTime.Now.Date.AddMonths(-6);
            return await _context.Bookings.Where(booking => booking.CreatedOn >= dateCriteria).ToListAsync();

        }

        public async Task<IEnumerable<Booking>> GetPastWeekBookings()
        {
            var dateCriteria = DateTime.Now.Date.AddDays(-7);

            return await _context.Bookings.Where(booking => booking.CreatedOn >= dateCriteria).ToListAsync();

        }

        public async Task<IEnumerable<Booking>> GetPastYearBookings()
        {
            var dateCriteria = DateTime.Now.Date.AddYears(-1);

            return await _context.Bookings.Where(booking => booking.CreatedOn >= dateCriteria).ToListAsync();

        }

        public int ModifyBooking(Booking booking)
        {
            var BookingInDb = _context.Bookings.Where(booking => booking.BookingId == booking.BookingId).SingleOrDefault();
            if (BookingInDb != null)
            {
                BookingInDb.CustomerId = booking.CustomerId;
                BookingInDb.CarId = booking.CarId;
                BookingInDb.DriverId = booking.DriverId;
                BookingInDb.FromDate = booking.FromDate;
                BookingInDb.ToDate = booking.ToDate;
                BookingInDb.FromLocation = booking.FromLocation;
                BookingInDb.ToLocation = booking.ToLocation;
                BookingInDb.NoOfPersons = booking.NoOfPersons;
                BookingInDb.BookingStatus = booking.BookingStatus;
                BookingInDb.JourneyCompletion = booking.JourneyCompletion;
                BookingInDb.PaymentStatus = booking.PaymentStatus;
                BookingInDb.UpdatedOn = booking.UpdatedOn;
                _context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
               
        }
    }
}
