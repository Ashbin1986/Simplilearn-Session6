<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="StudentEvents.aspx.cs" Inherits="Session6.StudentEvents" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container">
        <div>
            <br />
            <br />
            <asp:Label ID="lblEvents" runat="server" Text="Events"></asp:Label>
            :
            <asp:DropDownList ID="ddlEvents" Width="50%" runat="server"></asp:DropDownList>
        </div>
    </div>
    <div>
        <br />
        <asp:Button ID="btnSearchRecords" runat="server" Text="Search" OnClick="btnSearchRecords_Click" />
        <asp:GridView ID="gvStudentEvents" runat="server" AutoGenerateColumns="False" CellPadding="4" ForeColor="#333333" GridLines="None" Width="648px">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:TemplateField>
                    <HeaderTemplate>
                        Student Name
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblStudentName" runat="server" Text= '<%#Eval("StudentName")%>'> </asp:Label>
                        <asp:HiddenField ID="hdnStudentid" runat="server" value= '<%#Eval("StudentId")%>' />
                    </ItemTemplate>
                </asp:TemplateField>

                  <asp:TemplateField>
                    <HeaderTemplate>
                        Event Name
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblEventName" runat="server" Text= '<%#Eval("EventName")%>'> </asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                   <asp:TemplateField>
                    <HeaderTemplate>
                        Event Date
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:Label ID="lblEventDate" runat="server" Text= '<%#Eval("EventDate")%>'> </asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>

                 <asp:TemplateField>
                    <HeaderTemplate>
                        Action
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkEdit" runat="server" Text="Edit" CommandName="Edit" CommandArgument= '<%#Eval("StudentId")%>' OnCommand="lnkEdit_Command"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
                   <asp:TemplateField>
                    <HeaderTemplate>
                        Action
                    </HeaderTemplate>
                    <ItemTemplate>
                        <asp:LinkButton ID="linkDelete" runat="server" Text="Delete" CommandName="Delete" CommandArgument= '<%#Eval("StudentId")%>' OnCommand="lnkEdit_Command"></asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>

            <EditRowStyle BackColor="#7C6F57" />
            <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#E3EAEB" />
            <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F8FAFA" />
            <SortedAscendingHeaderStyle BackColor="#246B61" />
            <SortedDescendingCellStyle BackColor="#D4DFE1" />
            <SortedDescendingHeaderStyle BackColor="#15524A" />

        </asp:GridView>
    </div>

</asp:Content>
