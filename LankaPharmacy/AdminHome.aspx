<%@ Page Title="" Language="C#" MasterPageFile="~/LoginRegistrationMaster.Master" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="LankaPharmacy.AdminHome" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <ul class="nav">
              <li><a href="AdminHome.aspx" class="active" >Home</a></li>
              <li><a href="ManageOrders.aspx" >Manage Orders</a></li>
              <li><a href="ManageDrugs.aspx" >Manage Drugs</a></li>
              <li><a href="ManageUsers.aspx" >Manage Users</a></li>
            <li><a href="ManageEmployees.aspx" >Manage Employees</a></li>
            <li><a href="ManageWages.aspx" >Manage Wages</a></li>
              <li><a href="Reports.aspx" >Reports</a></li>
            </ul>
    </div>

     <div align="center">
         
        <asp:Panel ID="Panel1" runat="server" Height="149px" Width="219px" style="display:inline-block;" BackColor="#99CCFF">
            <h3>Number Of Registered Users</h3>
            <br />
            <asp:Label ID="lbl_users" runat="server"></asp:Label>
        </asp:Panel>
        
        &nbsp
        <asp:Panel ID="Panel2" runat="server" Height="149px" Width="217px" style="display:inline-block;"  BackColor="#99CCFF">
            <h3>Number Of Employees</h3>
            <br />
            <br />
            
            <asp:Label ID="lbl_employees" runat="server"></asp:Label>
        </asp:Panel>
        &nbsp
         
        <asp:Panel ID="Panel3" runat="server" Height="149px" Width="217px" style="display:inline-block;"  BackColor="#99CCFF">
            <h3>Number Of Total Orders</h3>
            <br />
            <br />
            <asp:Label ID="lbl_totalOrders" runat="server"></asp:Label>
        </asp:Panel>
        &nbsp
         
        <asp:Panel ID="Panel4" runat="server" Height="149px" Width="217px" style="display:inline-block;"  BackColor="#99CCFF">
            <h3>Date</h3>
            <br />
            <br />
            <asp:Label ID="lbl_date" runat="server"></asp:Label>
        </asp:Panel>
  
    </div>
    <br />
    <br />

    <br />


    <div align="center">
                            <asp:Button ID="btn_Logout" runat="server" Text="Logout" Style=" /* Green */border: none;color: white;padding: 10px 32px;text-align: center;text-decoration: none;display: inline-block;font-size: 16px;" Height="40px" Width="131px" Font-Bold="True"  BackColor="#99CCFF" OnClick="btn_update_Click" />
                    
    </div>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />

</asp:Content>
