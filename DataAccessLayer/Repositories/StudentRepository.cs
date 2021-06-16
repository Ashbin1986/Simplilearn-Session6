using DataAccessLayer.DBHelper;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        
        public void AddStudent(StudentEntity studentEntity)
        {
            DBHelperLayer dBHelper = new DBHelperLayer();
            dBHelper.AddStudent(studentEntity);
        }

        public DataSet GetEventParticipants()
        {
            DBHelperLayer dBHelper = new DBHelperLayer();
            return dBHelper.GetEventParticipants();
        }
    }
}
