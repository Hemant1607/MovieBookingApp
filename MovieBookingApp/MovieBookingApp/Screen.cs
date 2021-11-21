using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingApp
{
    class Screen
    {
        public Theatre theatre { get; set; }

        public List<Seat> seats = new List<Seat>();

        public List<Show> shows = new List<Show>();

        public int ScreenId { get; set; }
        public string ScreenName { get; set; }
    }
}
