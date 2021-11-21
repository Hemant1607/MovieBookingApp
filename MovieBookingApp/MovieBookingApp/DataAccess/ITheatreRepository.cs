using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingApp.DataAccess
{
    interface ITheatreRepository
    {
        void AddTheatre(Theatre theatre);
        void UpdateTheatre(int theatreId,Theatre theatre);
        void DeleteTheatre(int theatreId);

    }
}
