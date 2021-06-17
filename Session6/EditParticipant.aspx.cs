using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Session6
{
    public partial class EditParticipant : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                string studentId = Request.QueryString["id"];
                GetStudentData(Convert.ToInt32(studentId));
            }

        }

        private void GetStudentData(int studentId)
        {
            // DB Call to fetch data for a student
            // bind to the text box
           // for e.g txtStudent.Text = studentModel.StudentName;
        }
    }
}