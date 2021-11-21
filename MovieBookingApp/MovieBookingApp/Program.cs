using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieBookingApp.DataAccess;

namespace MovieBookingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ITicketBookingService ticket = new TicketBookingService();
            Console.WriteLine(ticket.GetTotalIncomeEarnedByTheatre("Theatre1"));
            Console.WriteLine(ticket.GetTotalNumberOfTicketsBookedByCity("City1"));
            Console.ReadLine();
        }
    }
}
