<%@ Page Title="" Language="C#" MasterPageFile="~/LoginRegistrationMaster.Master" AutoEventWireup="true" CodeBehind="ManageWages.aspx.cs" Inherits="LankaPharmacy.ManageWages" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style type="text/css">
        .auto-style11 {
            height: 38px;
        }
        .auto-style13 {
            height: 238px;
            margin: 0 auto;
            
            
            width: 639px;
        }
        .auto-style22 {
            width: 100%;
        }
         .auto-style23 {
             width: 274px;
             height: 53px;
         }
         .auto-style24 {
             height: 53px;
         }
         .auto-style25 {
             width: 277px;
             height: 52px;
         }
         .auto-style26 {
             height: 52px;
         }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <ul class="nav">
              <li><a href="AdminHome.aspx"  >Home</a></li>
              <li><a href="ManageOrders.aspx" >Manage Orders</a></li>
              <li><a href="ManageDrugs.aspx" >Manage Drugs</a></li>
              <li><a href="ManageUsers.aspx" >Manage Users</a></li>
            <li><a href="ManageEmployees.aspx"  >Manage Employees</a></li>
            <li><a href="ManageWages.aspx" class="active">Manage Wages</a></li>
              <li><a href="Reports.aspx" >Reports</a></li>
            </ul>
    </div>

    <div  style="font-family: 'Copperplate Gothic Bold'; " class="auto-style22" >
        
        <table  class="auto-style13"  >
            <tr>
                <td colspan="2" align="center" class="auto-style11"><h2>Manage Wages</h2></td>
            </tr>
            <tr>
                <td class="auto-style25" ><strong>Employee ID</strong></td>
                <td class="auto-style26" >
                    <asp:DropDownList ID="ddl_EID" runat="server" Width="319px">
                    </asp:DropDownList>
                </td>
                

            </tr>
            <tr>
                <td class="auto-style23" ><strong>Year</strong></td>
                <td class="auto-style24" ><asp:TextBox ID="txt_Year" runat="server" Width="313px"></asp:TextBox> 
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Please Enter Year!" ForeColor="Red" ControlToValidate="txt_Year"></asp:RequiredFieldValidator>
                </td>  
            </tr>
            <tr>
                <td class="auto-style25" ><strong>Month</strong></td>
                <td class="auto-style26" >
                    &nbsp;<asp:DropDownList ID="ddl_Month" runat="server" Width="319px">
                        <asp:ListItem>January</asp:ListItem>
                        <asp:ListItem>February</asp:ListItem>
                        <asp:ListItem>March</asp:ListItem>
                        <asp:ListItem>April</asp:ListItem>
                        <asp:ListItem>May</asp:ListItem>
                        <asp:ListItem>June</asp:ListItem>
                        <asp:ListItem>July</asp:ListItem>
                        <asp:ListItem>August</asp:ListItem>
                        <asp:ListItem>September</asp:ListItem>
                        <asp:ListItem>October</asp:ListItem>
                        <asp:ListItem>November</asp:ListItem>
                        <asp:ListItem>December</asp:ListItem>
                    </asp:DropDownList>
                </td>
                
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btn_add" runat="server" Text="Add" Style="background-color: lightslategray; /* Green */border: none;color: white;padding: 10px 32px;text-align: center;text-decoration: none;display: inline-block;font-size: 16px;" Height="40px" Width="131px" Font-Bold="True" OnClick="btn_add_Click" BackColor="#CC66FF" />
                    &nbsp;
                    &nbsp;
                    <asp:Button ID="btn_delete" runat="server" Text="Delete" Style="background-color: lightslategray;  /* Green */border: none;color: white;padding: 10px 32px;text-align: center;text-decoration: none;display: inline-block;font-size: 16px;" Height="40px" Width="131px" Font-Bold="True" OnClick="btn_delete_Click" BackColor="#99CCFF" />
                    &nbsp;
                    </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Label ID="lbl_msg" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    <div algin="center">
        
        
        <asp:GridView ID="gv_wages" runat="server" CellPadding="4" align="center" ForeColor="#333333" GridLines="None" Width="725px" AutoGenerateSelectButton="True" OnSelectedIndexChanged="gv_wages_SelectedIndexChanged">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        
    </div>
</asp:Content>
