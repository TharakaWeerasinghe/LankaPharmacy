using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace LankaPharmacy
{
    public partial class InventoryReport : System.Web.UI.Page
    {
        SQLDataManipulator sdm = new SQLDataManipulator();
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = sdm.dispalyData("Select Drug_ID,Drug_Name,Stock from Drug");
            gv_Inventory.DataSource = dt;
            gv_Inventory.DataBind();
        }
    

        protected void btn_update_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reports.aspx");
        }
    }
}