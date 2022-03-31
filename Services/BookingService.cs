using Entities.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookingService : IBookingService
    {
        private readonly IBookingRepository _bookingRepository;
        public BookingService(IBookingRepository bookingRepository)
        {
            _bookingRepository = bookingRepository;
        }
        public int AddBooking(Booking booking)
        {
            return _bookingRepository.AddBooking(booking);
        }

        public int DeleteBooking(int id)
        {
            return _bookingRepository.DeleteBooking(id);
        }

        public Task<IEnumerable<Booking>> GetAllBookingForCustomerWithId(int id)
        {
            return _bookingRepository.GetAllBookingForCustomerWithId(id);
        }

        public Task<IEnumerable<Booking>> GetAllBookings()
        {
            return _bookingRepository.GetAllBookings();
        }

        public Task<IEnumerable<Booking>> GetAllConfirmedBookings()
        {
            return _bookingRepository.GetAllConfirmedBookings();
        }

        public Task<IEnumerable<Booking>> GetAllJourneyCompletedBookings()
        {
            return _bookingRepository.GetAllJourneyCompletedBookings();
        }

        public Task<IEnumerable<Booking>> GetAllPaymentCompletedBookings()
        {
            return _bookingRepository.GetAllPaymentCompletedBookings();
        }

        public Task<IEnumerable<Booking>> GetAllPendingBookings()
        {
            return _bookingRepository.GetAllPendingBookings();
        }

        public Task<IEnumerable<Booking>> GetPastMonthBookings()
        {
            return _bookingRepository.GetPastMonthBookings();
        }

        public Task<IEnumerable<Booking>> GetPastSixMonthBookings()
        {
            return _bookingRepository.GetPastSixMonthBookings();
        }

        public Task<IEnumerable<Booking>> GetPastWeekBookings()
        {
            return _bookingRepository.GetPastWeekBookings();
        }

        public Task<IEnumerable<Booking>> GetPastYearBookings()
        {
            return _bookingRepository.GetPastYearBookings();
        }

        public int ModifyBooking(Booking booking)
        {
            return _bookingRepository.ModifyBooking(booking);
        }
    }
}
