using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingApp.DataAccess
{
    interface IAddressRepository
    {
        void AddAddress(Address address);
        void UpdateAddress(string HouseNo, Address address);
        void DeleteTheatre(string HouseNo);
    }
}
