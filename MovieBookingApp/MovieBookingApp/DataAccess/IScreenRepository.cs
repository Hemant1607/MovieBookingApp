using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieBookingApp.DataAccess
{
    interface IScreenRepository
    {
        void AddScreen(IScreenRepository screen);
        void UpdateScreen(int screenId, IScreenRepository screen);
        void DeleteScreen(int screenId);
    }
}
