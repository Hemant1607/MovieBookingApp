using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingApp.DataAccess
{
    interface ITicketBookingService
    {
        double GetTotalIncomeEarnedByTheatre(string theatreName);

        List<string> GetAllMovieNamesSeenByUserInTheatre(string theatreName, string LoginName);

        int GetTotalNumberOfTicketsBookedByCity(string cityName);

        void DisplayReport(string movieName);



    }
}
