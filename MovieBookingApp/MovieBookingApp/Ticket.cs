using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingApp
{
    class Ticket
    {
        public List<Seat> seats = new List<Seat>();

        public Booking booking { get; set; }
        public long TicketId { get; set; }
    }
}
