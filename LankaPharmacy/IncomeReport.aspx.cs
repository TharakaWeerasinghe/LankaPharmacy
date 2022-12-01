using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace LankaPharmacy
{
    public partial class IncomeReport : System.Web.UI.Page
    {
        SQLDataManipulator sdm = new SQLDataManipulator();
        protected void Page_Load(object sender, EventArgs e)
        {

            //loading the total of all orders
            DataTable dt = sdm.dispalyData("SELECT SUM(Total) as Total_Income FROM Orders");
            gv_Income.DataSource = dt;
            gv_Income.DataBind();
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reports.aspx");
        }
    }
}