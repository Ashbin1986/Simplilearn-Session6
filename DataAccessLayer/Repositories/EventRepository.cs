using DataAccessLayer.DBHelper;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class EventRepository : IEventRepository
    {
        public void AddEvent(EventsEntity eventsEntity)
        {
            DBHelperLayer dBHelper = new DBHelperLayer();
            dBHelper.AddEvent(eventsEntity);
        }

        public void DeleteEvent(int eventId)
        {
            DBHelperLayer dBHelper = new DBHelperLayer();
            dBHelper.DeleteEvent(eventId);
        }
    }
}
