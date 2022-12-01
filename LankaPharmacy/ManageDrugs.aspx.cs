using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace LankaPharmacy
{
    public partial class ManageDrugs : System.Web.UI.Page
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

        protected void btn_add_Click(object sender, EventArgs e)
        {
            // adding a new drug to the db
            
            try
            {
                sdm.modifyData("Insert into Drug (Drug_ID,Drug_Name,Manufacturer,EXD,Drug_Description,Stock,Price) values('" + txt_DID.Text + "','" + txt_Dname.Text + "','" + txt_Manufacturer.Text + "','" + txt_EXD.Text + "','" + txt_Ddescription.Text + "','" + int.Parse(txt_Stock.Text) + "','" + float.Parse(txt_Price.Text) + "')");
                lbl_msg.Text = "Drug Added Successfully!";
                loadDrugs();
            }
            catch (Exception ex)
            {

                lbl_msg.Text = ex.Message.ToString();
            }
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            // updating drug info
            
            try
            {
                sdm.modifyData("Update Drug Set Drug_Name='" + txt_Dname.Text + "',Manufacturer='" + txt_Manufacturer.Text + "',EXD='" + txt_EXD.Text + "',Drug_Description='" + txt_Ddescription.Text + "',Stock='" + int.Parse(txt_Stock.Text) + "',Price='" + float.Parse(txt_Price.Text) + "' where Drug_ID='" + txt_DID.Text + "' ");
                lbl_msg.Text = "Drug Updated Successfully!";
                loadDrugs();
            }
            catch (Exception ex)
            {


                lbl_msg.Text = ex.Message.ToString();
            }
        }

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            //deleting drugs from db
            try
            {
                sdm.modifyData("Delete from Drug where Drug_ID='" + txt_DID.Text + "'");
                lbl_msg.Text = "Drug Deleted Successfully!";
                loadDrugs();
            }
            catch (Exception ex)
            {

                lbl_msg.Text = ex.Message.ToString();
            }
        }

        protected void gv_Books_SelectedIndexChanged(object sender, EventArgs e)
        {
          

            //autofilling the form fields when clicking on a grid view item
            if (gv_Drugs.SelectedIndex != -1)
            {
                txt_DID.Text = gv_Drugs.SelectedRow.Cells[1].Text;
                txt_Dname.Text = gv_Drugs.SelectedRow.Cells[2].Text;
                txt_Manufacturer.Text = gv_Drugs.SelectedRow.Cells[3].Text;
                txt_EXD.Text = gv_Drugs.SelectedRow.Cells[4].Text;
                txt_Ddescription.Text = gv_Drugs.SelectedRow.Cells[5].Text;
                txt_Stock.Text = gv_Drugs.SelectedRow.Cells[6].Text;
                txt_Price.Text = gv_Drugs.SelectedRow.Cells[7].Text;
            }
        }
    }
}