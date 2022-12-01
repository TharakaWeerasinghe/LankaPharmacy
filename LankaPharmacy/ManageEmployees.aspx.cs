using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace LankaPharmacy
{
    public partial class ManageEmployees : System.Web.UI.Page
    {
        SQLDataManipulator sdm = new SQLDataManipulator();
        protected void Page_Load(object sender, EventArgs e)
        {
            loadEmployees();
        }

        protected void loadEmployees()
        {
            // loading Employees info from db 
            DataTable dt = sdm.dispalyData("Select * from Employee order by Employee_ID asc");
            gv_Employees.DataSource = dt;
            gv_Employees.DataBind();
        }

        protected void btn_Search_Click(object sender, EventArgs e)
        {
            try
            {
                //searching for a paticular employee according to the input text
                DataTable dt = sdm.dispalyData("select * from Employee where Employee_ID like '" + txt_search.Text + "'+'%'");
                gv_Employees.DataSource = dt;
                gv_Employees.DataBind();
            }
            catch (Exception ex)
            {

                lbl_msg.Text = ex.Message.ToString();
            }
        }

        protected void btn_add_Click(object sender, EventArgs e)
        {
            try
            {//adding a new user to the db
                sdm.modifyData("insert into Employee (Employee_ID,First_Name,Last_Name,CNO,Salary,Age,Email,Address,Employee_Type) values ('" + employee_ID.Text + "','" + Fname.Text + "','" + Lname.Text + "','"+CNo.Text+"','"+float.Parse(Salary.Text)+"','" + int.Parse(Age.Text) + "','" + Email.Text + "','" + Address.Text + "','"+ddl_Etype.Text+"')");
                lbl_msg.Text = "Employee Added Successfully!";
                loadEmployees();
            }
            catch (Exception ex)
            {
                lbl_msg.Text = ex.Message.ToString();

            }
        }

        protected void btn_update_Click(object sender, EventArgs e)
        {
            try
            {//updating user details
                sdm.modifyData("Update Employee set First_Name='" + Fname.Text + "',Last_Name='" + Lname.Text + "',CNO='"+CNo.Text+ "',Salary='"+float.Parse(Salary.Text)+"',Age='" + int.Parse(Age.Text) + "',Email='" + Email.Text + "',Address='" + Address.Text + "',Employee_Type='" + ddl_Etype.Text + "' where Employee_ID='" + employee_ID.Text + "'");
                lbl_msg.Text = "Employee Updated Successfully!";
                loadEmployees();
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
                sdm.modifyData("Delete from Employee where Employee_ID='" + employee_ID.Text + "' ");
                loadEmployees();
                lbl_msg.Text = "Employee Deleted Successfully!";
            }
            catch (Exception ex)
            {

                lbl_msg.Text = ex.Message.ToString();
            }
        }

        protected void gv_Employees_SelectedIndexChanged(object sender, EventArgs e)
        {
            //autofilling the form fields when clicking on a grid view item
            if (gv_Employees.SelectedIndex != -1)
            {
                employee_ID.Text = gv_Employees.SelectedRow.Cells[1].Text;
                Fname.Text = gv_Employees.SelectedRow.Cells[2].Text;
                Lname.Text = gv_Employees.SelectedRow.Cells[3].Text;
                CNo.Text = gv_Employees.SelectedRow.Cells[4].Text;
                Salary.Text = gv_Employees.SelectedRow.Cells[5].Text;
                Age.Text = gv_Employees.SelectedRow.Cells[6].Text;
                Email.Text = gv_Employees.SelectedRow.Cells[7].Text;
                Address.Text = gv_Employees.SelectedRow.Cells[8].Text;
                ddl_Etype.Text = gv_Employees.SelectedRow.Cells[9].Text;
            }
        }
    }
}