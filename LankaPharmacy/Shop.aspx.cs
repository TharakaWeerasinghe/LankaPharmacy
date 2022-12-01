using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace LankaPharmacy
{
    public partial class Shop : System.Web.UI.Page
    {
        SQLDataManipulator sdm = new SQLDataManipulator();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                loadDrugs();
            }
        }

        protected void loadDrugs()
        {// loading drug info from db 
            DataTable dt = sdm.dispalyData("Select * from  Drug order by Drug_ID asc");
            gv_Drugs.DataSource = dt;
            gv_Drugs.DataBind();
        }

        protected void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                //searching for a paticular drug according to the input text
                DataTable dt = sdm.dispalyData("select * from Drug where Drug_Name like '" + txt_search.Text + "'+'%'");
                gv_Drugs.DataSource = dt;
                gv_Drugs.DataBind();
            }
            catch (Exception ex)
            {

                lbl_msg.Text = ex.Message.ToString();
            }
        }

        protected void btn_addtoCart_Click(object sender, EventArgs e)
        {
            try
            {
                Session["AddDrug"] = true;
                Response.Redirect("Cart.aspx?Drug_ID=" + gv_Drugs.SelectedRow.Cells[1].Text + "&Quantity=" + txt_quantity.Text + "&Drug_Name=" + gv_Drugs.SelectedRow.Cells[2].Text + "&Price=" + gv_Drugs.SelectedRow.Cells[7].Text);
            }
            catch (Exception ex)
            {

                lbl_msg.Text = ex.Message.ToString();
            }
        }

        protected void btn_viewCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("Cart.aspx");
        }
    }
}