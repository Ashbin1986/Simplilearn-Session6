using DomainServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainServices.Services
{
    public interface IEventsDomainService
    {
        void AddEvent(EventsModel eventsModel);

        void DeleteEvent(int eventId);

        List<EventsModel> GetEvents(int eventId);
    }
}
