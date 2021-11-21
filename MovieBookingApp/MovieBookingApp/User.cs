using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingApp
{
    class User
    {
        public Address address { get; set; }

        public List<Booking> bookings = new List<Booking>();
        public long UserId { get; set; }
        public string LoginName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
