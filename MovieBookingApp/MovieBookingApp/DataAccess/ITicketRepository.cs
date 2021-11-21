using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingApp.DataAccess
{
    interface ITicketRepository
    {
        void AddTicket(Ticket ticket);
        void UpdateTicket(int ticketId, Ticket ticket);
        void DeleteTicket(int ticketId);
    }
}
