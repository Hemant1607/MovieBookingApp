using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingApp.DataAccess
{
    interface IShowRepository
    {
        void AddShow(Show show);
        void UpdateShow(int showId, Show show);
        void DeleteShow(int showId);
    }
}
