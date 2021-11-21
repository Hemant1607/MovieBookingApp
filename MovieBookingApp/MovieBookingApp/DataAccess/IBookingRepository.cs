using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingApp.DataAccess
{
    interface IBookingRepository
    {
        void AddBooking(Booking booking);
        void UpdateBooking(int bookingId, Booking booking);
        void DeleteBooking(int bookingId);
    }
}
