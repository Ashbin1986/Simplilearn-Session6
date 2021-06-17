using DomainServices.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Session6
{
    public partial class StudentEvents : System.Web.UI.Page
    {
        #region Page Events
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                LoadEvents();
            }

        }

        #endregion

        #region Control events
        protected void btnSearchRecords_Click(object sender, EventArgs e)
        {
            GetEventsData();

        }
      
        protected void lnkEdit_Command(object sender, CommandEventArgs e)
        {
            LinkButton lnk = sender as LinkButton;

            if(e.CommandName == "Edit")
            {
                //EDIT
                Response.Redirect("EditParticipant.aspx?id=" + lnk.CommandArgument);
            }
            else if (e.CommandName == "Delete")
            {
                StudentDomainService studentDomainService = new StudentDomainService();
                GetEventsData();
                // AFter deleteing - needs to rebind the grid

            }

            

        }


        #endregion

        #region private methods
        private void LoadEvents()
        {
            IEventsDomainService eventsDomainService = new EventsDomainService();

            ddlEvents.DataSource = eventsDomainService.GetEvents(0);
            ddlEvents.DataTextField = "EventName";
            ddlEvents.DataValueField = "EventId";
            ddlEvents.DataBind();
        }

        private void GetEventsData()
        {
            IStudentDomainService studentDomainService = new StudentDomainService();

            var eventsResponse = studentDomainService.GetEventParticipants();

            eventsResponse = eventsResponse.Where(c => c.EventId == Convert.ToInt32(ddlEvents.SelectedValue)).ToList();

            gvStudentEvents.DataSource = eventsResponse;
            gvStudentEvents.DataBind();
        }


        #endregion

    }
}