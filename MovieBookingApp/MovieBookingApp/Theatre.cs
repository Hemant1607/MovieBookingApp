using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingApp
{
    class Theatre
    {
        public List<Screen> screens = new List<Screen>();
        public int TheatreId { get; set; }
        public string TheatreName { get; set; }

    }
}
