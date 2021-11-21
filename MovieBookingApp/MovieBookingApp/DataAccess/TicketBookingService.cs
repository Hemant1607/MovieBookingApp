using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingApp.DataAccess
{
    class TicketBookingService : ITicketBookingService
    {
        public void DisplayReport(string movieName)
        {
            throw new NotImplementedException();
        }

        public List<string> GetAllMovieNamesSeenByUserInTheatre(string theatreName, string LoginName)
        {
            throw new NotImplementedException();
        }

        public double GetTotalIncomeEarnedByTheatre(string theatreName)
        {
            throw new NotImplementedException();
        }

        public int GetTotalNumberOfTicketsBookedByCity(string cityName)
        {
            throw new NotImplementedException();
        }

        private SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["movies"].ConnectionString;
            return conn;
        }
    }
}
