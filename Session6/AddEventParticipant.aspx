<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddEventParticipant.aspx.cs" Inherits="Session6.AddEventParticipant" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
  
    
     <div class="form-horizontal">
        <h4>  Add Participant</h4>
        <hr />
        
       
        <div class="form-group">
          
            <div class="col-md-2">
                Student Name
            </div>
            <div class="col-md-10">
                <asp:TextBox ID="txtStudent" runat="server"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-2">
               Event Name
            </div>
            <div class="col-md-10">
                 <asp:DropDownList ID="ddlEvents" Width="18.5%" runat="server"></asp:DropDownList></div>
            </div>
        
     <div class="form-group">
             <div class="col-md-2">
                Gender
            </div>
            <div class="col-md-10">
                <asp:RadioButton ID="rdbMale" runat="server"  GroupName="Gender"  />Male <asp:RadioButton ID="rdbFeMale" runat="server"  GroupName="Gender" /> Female   
            </div>
        </div>
        
             
     <div class="form-group">
            <div class="col-md-2">
                Student Email
            </div>
            <div class="col-md-10">
                  <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="regExptxtEmail" runat="server"
                    ErrorMessage="Email not valid" ForeColor="Red" Display="Dynamic" ControlToValidate="txtEmail"
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">
                  </asp:RegularExpressionValidator>
            </div>
        </div>
        <div class="form-group">
            <div class="col-md-offset-2 col-md-10">
                <asp:Button ID="btnAddStudentEvent" runat="server" Text="Add Participant" OnClick="btnAddStudentEvent_Click"/>
            </div>
        </div>
    </div>

</asp:Content>
