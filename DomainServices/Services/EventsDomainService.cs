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


        public List<EventsModel> GetEvents(int eventId)
        {
            IEventRepository eventRepository = new EventRepository();

            List<EventsModel> eventsModels = new List<EventsModel>();

            var events = eventRepository.GetEvents();

            if (events != null)
            {
                if (eventId == 0)
                {
                    foreach (var e in events)
                    {
                        eventsModels.Add(new EventsModel
                        {
                            EventId = e.EventId,
                            EventName = e.EventName
                        });
                    }
                }
                else
                {
                    var filteredEvent = events.Where(c => c.EventId == eventId).FirstOrDefault();

                    eventsModels.Add(new EventsModel
                    {
                        EventId = filteredEvent.EventId,
                        EventName = filteredEvent.EventName
                    });
                }
            }

            return eventsModels;
        }
    }
}
