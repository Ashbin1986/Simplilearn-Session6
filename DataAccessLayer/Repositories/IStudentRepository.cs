using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public interface IStudentRepository
    {
        void AddStudent(StudentEntity studentEntity);

        DataSet GetEventParticipants();
    }
}
