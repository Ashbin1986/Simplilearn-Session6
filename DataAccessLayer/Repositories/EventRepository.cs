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

        public List<EventsEntity> GetEvents()
        {
            DBHelperLayer dBHelper = new DBHelperLayer();

            List<EventsEntity> eventsEntities = new List<EventsEntity>();

            var events = dBHelper.GetEvents();

            for (int i = 0; i < events.Tables["EventsData"].Rows.Count; i++)
            {
                eventsEntities.Add(new EventsEntity
                {

                    EventName = events.Tables["EventsData"].Rows[i]["EventName"].ToString(),
                    EventId = Convert.ToInt32(events.Tables["EventsData"].Rows[i]["EventId"].ToString())

                });
            }
            return eventsEntities;

        }
    }
}
