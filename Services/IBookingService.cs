using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface IBookingService
    {
        int AddBooking(Booking booking);
        int ModifyBooking(Booking booking);
        int DeleteBooking(int id);
        Task<IEnumerable<Booking>> GetAllBookings();
        Task<IEnumerable<Booking>> GetAllPendingBookings();
        Task<IEnumerable<Booking>> GetAllConfirmedBookings();
        Task<IEnumerable<Booking>> GetPastWeekBookings();
        Task<IEnumerable<Booking>> GetPastMonthBookings();
        Task<IEnumerable<Booking>> GetPastSixMonthBookings();
        Task<IEnumerable<Booking>> GetPastYearBookings();
        Task<IEnumerable<Booking>> GetAllBookingForCustomerWithId(int id);
        Task<IEnumerable<Booking>> GetAllJourneyCompletedBookings();
        Task<IEnumerable<Booking>> GetAllPaymentCompletedBookings();
    }
}
