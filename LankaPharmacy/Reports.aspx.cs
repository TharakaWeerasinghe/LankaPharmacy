using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LankaPharmacy
{
    public partial class Reports : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void btn_IncomReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("IncomeReport.aspx");
        }

        protected void btn_InventoryReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("InventoryReport.aspx");
        }

        protected void btn_CusReport_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerReport.aspx");
        }

        protected void Btn_bestsellers_Click(object sender, EventArgs e)
        {
            Response.Redirect("BestSellers.aspx");
        }
    }
}