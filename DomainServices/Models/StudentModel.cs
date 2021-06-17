using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainServices.Models
{
   public class StudentModel
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }
        public int EventId { get; set; }
    }

    public class StudentEventsModel
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        public int  EventId { get; set; }
    }
}
