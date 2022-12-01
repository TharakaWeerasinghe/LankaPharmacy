using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace LankaPharmacy
{
   
    public partial class AdminHome : System.Web.UI.Page
    {
        SQLDataManipulator sdm = new SQLDataManipulator();
        protected void Page_Load(object sender, EventArgs e)
        {
            lbl_date.Text = DateTime.Now.ToShortDateString();
            string user = Session["Username"].ToString();
            DataTable dt = sdm.dispalyData("select count (Order_ID) from Orders ");
            lbl_totalOrders.Text = dt.Rows[0][0].ToString();
            DataTable dt2 = sdm.dispalyData("select count (Username) from Users ");
            lbl_users.Text = dt2.Rows[0][0].ToString();
            DataTable dt3 = sdm.dispalyData("select count (Employee_ID) from Employee ");
            lbl_employees.Text = dt3.Rows[0][0].ToString();
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("Login.aspx");
        }
    }
}