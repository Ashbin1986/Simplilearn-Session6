using DataAccessLayer.Repositories;
using DomainServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainServices.Services
{
    public class EventsDomainService : IEventsDomainService
    {
        public void AddEvent(EventsModel eventsModel)
        {
            IEventRepository eventRepository = new EventRepository();
           
            eventRepository.AddEvent(new DataAccessLayer.Models.EventsEntity
            {
                EventDate = eventsModel.EventDate,
                EventName = eventsModel.EventName
            });
        }

        public void DeleteEvent(int eventId)
        {
            IEventRepository eventRepository = new EventRepository();

            eventRepository.DeleteEvent(eventId);
        }
    }
}
