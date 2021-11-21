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
            SqlConnection conn = GetConnection();
            double income;
            try
            {
                //throw new NotImplementedException();
                
                string SqlIncome = $"select sum(Cost) from Show where ScreenId in(select ScreenId from Screen where TheatreId in(select TheatreId from Theatre where TheatreName='{theatreName}'))";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = SqlIncome;
                cmd.Connection = conn;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                income = (double)reader[0];
            }
            finally
            {
                conn.Close();
            }
            return income;
        }

        public int GetTotalNumberOfTicketsBookedByCity(string cityName)
        {
            //throw new NotImplementedException();
            SqlConnection conn = GetConnection();
            int num;
            try
            {
                //throw new NotImplementedException();

                string SqlIncome = $"select count(TicketId) from Ticket where BookingId in(Select BookingId from Booking where UserId in(select UserId from Users where HouseNo in(select HouseNo from Address where City='{cityName}') ))";
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = SqlIncome;
                cmd.Connection = conn;
                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                num = (int)reader[0];
            }
            finally
            {
                conn.Close();
            }
            return num;
        }

        private SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["movies"].ConnectionString;
            return conn;
        }
    }
}
