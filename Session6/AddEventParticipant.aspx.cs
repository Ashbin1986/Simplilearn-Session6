using DomainServices.Services;
using DomainServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Session6
{
    public partial class AddEventParticipant : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                LoadEvents();
            }
        }
        private void LoadEvents()
        {
            IEventsDomainService eventsDomainService = new EventsDomainService();

            ddlEvents.DataSource = eventsDomainService.GetEvents(0);
            ddlEvents.DataTextField = "EventName";
            ddlEvents.DataValueField = "EventId";
            ddlEvents.DataBind();
        }

        protected void btnAddStudentEvent_Click(object sender, EventArgs e)
        {
            IStudentDomainService studentDomainService = new StudentDomainService();

            studentDomainService.AddStudent(new StudentModel
            {
                Email = txtEmail.Text,
                StudentName = txtStudent.Text,
                IsActive = true,
                Gender = GetGender(),
                EventId = Convert.ToInt32(ddlEvents.SelectedValue.ToString())

            });
        }

        public string GetGender()
        {
            if (rdbFeMale.Checked)
            {
                return "F";
            }
            else if (rdbMale.Checked)
            {
                return "M";
            }
            else
            {
                return "O";
            }
        }
    }
}