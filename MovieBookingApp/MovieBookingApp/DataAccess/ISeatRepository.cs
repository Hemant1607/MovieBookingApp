using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingApp.DataAccess
{
    interface ISeatRepository
    {
        void AddSeat(Seat seat);
        void UpdateSeat(int seatId, Seat seat);
        void DeleteSeat(int seatId);
    }
}
