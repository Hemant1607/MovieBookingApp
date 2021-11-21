using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingApp
{
    class Seat
    {
        public Ticket ticket { get; set; }
        public char RowId { get; set; }
        public int SeatId { get; set; }
    }
}
