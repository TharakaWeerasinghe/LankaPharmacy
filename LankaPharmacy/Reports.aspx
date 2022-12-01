<%@ Page Title="" Language="C#" MasterPageFile="~/LoginRegistrationMaster.Master" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="LankaPharmacy.Reports" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
        <ul class="nav">
              <li><a href="AdminHome.aspx"  >Home</a></li>
              <li><a href="ManageOrders.aspx" >Manage Orders</a></li>
              <li><a href="ManageDrugs.aspx" >Manage Drugs</a></li>
              <li><a href="ManageUsers.aspx" >Manage Users</a></li>
            <li><a href="ManageEmployees.aspx"  >Manage Employees</a></li>
            <li><a href="ManageWages.aspx" >Manage Wages</a></li>
              <li><a href="Reports.aspx"  class="active">Reports</a></li>
            </ul>
    </div>

    <div align="center">
        <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
         &nbsp
        <asp:Button ID="btn_IncomReport" runat="server" Text="Income Report" Style=" /* Green */border: none;color: white;padding: 10px 32px;text-align: center;text-decoration: none;font-size: 16px;" Height="40px" Width="269px" Font-Bold="True"  BackColor="#99CCFF" OnClick="btn_IncomReport_Click"  />
        <br />
        <br />
        &nbsp
        <asp:Button ID="btn_InventoryReport" runat="server" Text="Inventory Report" Style=" /* Green */border: none;color: white;padding: 10px 32px;text-align: center;text-decoration: none;font-size: 16px;" Height="40px" Width="269px" Font-Bold="True"  BackColor="#99CCFF" OnClick="btn_InventoryReport_Click"  />
        <br />
        <br />
         &nbsp
        <asp:Button ID="btn_CusReport" runat="server" Text="Customer Report" Style="  /* Green */border: none;color: white;padding: 10px 32px;text-align: center;text-decoration: none;font-size: 16px;" Height="40px" Width="269px" Font-Bold="True"  BackColor="#99CCFF" OnClick="btn_CusReport_Click"  />

        <br />
        <br />
         &nbsp
        <asp:Button ID="Btn_bestsellers" runat="server" Text="Best Sellers" Style="  /* Green */border: none;color: white;padding: 10px 32px;text-align: center;text-decoration: none;font-size: 16px;" Height="40px" Width="269px" Font-Bold="True"  BackColor="#99CCFF" OnClick="Btn_bestsellers_Click"  />

        <br />
        <br />
         &nbsp
                
    </div>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>


