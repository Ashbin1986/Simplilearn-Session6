using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public interface IEventRepository
    {
        void AddEvent(EventsEntity eventsEntity);

        void DeleteEvent(int  eventId);

        List<EventsEntity> GetEvents();
        
    }
}
