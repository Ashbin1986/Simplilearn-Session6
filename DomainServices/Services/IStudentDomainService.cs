using DomainServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainServices.Services
{
    interface IStudentDomainService
    {
        void AddStudent(StudentModel  studentModel);

        List<StudentEventsModel> GetEventParticipants();

    }
}
