using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingApp
{
    class Show
    {
        public List<Booking> bookings = new List<Booking>();

        public Movie movie { get; set; }
        public int ShowId { get; set; }
        public DateTime ShowTime { get; set; }
        public double Cost { get; set; }
    }
}
