using DataAccessLayer.Models;
using DataAccessLayer.Repositories;
using DomainServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainServices.Services
{
    public class StudentDomainService : IStudentDomainService
    {
        public void AddStudent(StudentModel studentModel)
        {
            IStudentRepository studentRepository = new StudentRepository();

            studentRepository.AddStudent(new StudentEntity
            {
                Email = studentModel.Email,
                Gender = studentModel.Gender,
                IsActive = studentModel.IsActive,
                StudentName = studentModel.StudentName
            });
        }

        public List<StudentEventsModel> GetEventParticipants()
        {
            IStudentRepository studentRepository = new StudentRepository();

            var result = studentRepository.GetEventParticipants();

            List<StudentEventsModel> lstStudentViews = new List<StudentEventsModel>();

            if (result != null && result.Tables.Count > 0)
            {
                for (int i = 0; i <= result.Tables[0].Rows.Count; i++)
                {
                    StudentEventsModel studentEventsModel = new StudentEventsModel();
                    studentEventsModel.EventDate = Convert.ToDateTime(result.Tables[0].Rows[i]["EventDate"].ToString());
                    studentEventsModel.EventId = Convert.ToInt32(result.Tables[0].Rows[i]["Eventid"].ToString());
                    studentEventsModel.EventName = result.Tables[0].Rows[i]["EventName"].ToString();
                    studentEventsModel.StudentName = result.Tables[0].Rows[i]["StudentName"].ToString();
                    studentEventsModel.StudentId = Convert.ToInt32(result.Tables[0].Rows[i]["StudentId"].ToString());

                    lstStudentViews.Add(studentEventsModel);
                }
            }
            return lstStudentViews;
        }
    }
}
