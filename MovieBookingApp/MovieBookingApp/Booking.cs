using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingApp
{
    class Booking
    {
        public User user { get; set; }

        public List<Ticket> tickets = new List<Ticket>();

        public Show show { get; set; }
        public long BookingId { get; set; }
        public DateTime BookingDate { get; set; }

    }
}
