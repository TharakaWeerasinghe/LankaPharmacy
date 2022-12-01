using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace LankaPharmacy
{
    public partial class ManageWages : System.Web.UI.Page
    {
        SQLDataManipulator sdm = new SQLDataManipulator();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dt = sdm.dispalyData("Select * from Employee order by Employee_ID asc");
                foreach (DataRow dr in dt.Rows)
                {
                    ddl_EID.Items.Add(dr["Employee_ID"].ToString());
                }
                loadSalaries();
            }
        }

        protected void loadSalaries()
        {
            // loading Users info from db 
            DataTable dt = sdm.dispalyData("Select * from EmployeeWage order by Employee_ID asc");
            gv_wages.DataSource = dt;
            gv_wages.DataBind();
        }

        protected void btn_add_Click(object sender, EventArgs e)
        {
            // add a wage record to the db
            try
            {
                DataTable dt = sdm.dispalyData("Select * from EmployeeWage where Employee_ID='" + ddl_EID.Text + "' and Year='" + txt_Year.Text + "' and Month='" + ddl_Month.Text + "'");
                if (dt.Rows.Count == 1)
                {
                    lbl_msg.Text = "Wage Record Already Exists!";
                }
                else
                {
                    sdm.modifyData("Insert into EmployeeWage(Employee_ID,Year,Month,Status) values('" + ddl_EID.Text + "','" + txt_Year.Text + "','" + ddl_Month.Text + "','Paid')");
                    lbl_msg.Text = "Wage Record Added!";
                    loadSalaries();
                }
            }
            catch (Exception ex)
            {

                lbl_msg.Text = ex.Message.ToString();
            }
            
        }

      

        protected void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {//deleting a user from the db
                sdm.modifyData("Delete from EmployeeWage where Employee_ID='" + ddl_EID.Text + "' and Year='"+txt_Year.Text+"' and Month='"+ddl_Month.Text+"' ");
                loadSalaries();
                lbl_msg.Text = "Record Deleted Successfully!";
            }
            catch (Exception ex)
            {

                lbl_msg.Text = ex.Message.ToString();
            }
        }

        protected void gv_wages_SelectedIndexChanged(object sender, EventArgs e)
        {
            //autofilling the form fields when clicking on a grid view item
            if (gv_wages.SelectedIndex != -1)
            {
                ddl_EID.Text = gv_wages.SelectedRow.Cells[1].Text;
                txt_Year.Text = gv_wages.SelectedRow.Cells[2].Text;
                ddl_Month.Text = gv_wages.SelectedRow.Cells[3].Text;
            }
        }
    }
}