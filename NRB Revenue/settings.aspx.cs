using System;
using NRB_Revenue.Model;
using NRB_Revenue.QueryBank;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace NRB_Revenue
{
    public partial class settings : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            if(Person.GetUserByUserName(searchtxtbox.Text).Rows.Count==0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('There is No System User with that Name');", true);
                RevuserGridView.DataSource = null;
                RevuserGridView.DataBind();
            }
            else if(searchtxtbox.Text == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Please fill the Text Box Search..!!!!');", true);
                RevuserGridView.DataSource = null;
                RevuserGridView.DataBind();
            }
            else
            {
                RevuserGridView.DataSource = Person.GetUserByUserName(searchtxtbox.Text);
                RevuserGridView.DataBind();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        protected void btnsubimt_Click(object sender, EventArgs e)
        {
            if(Person.GetUserByUserName(txtusername.Text).Rows.Count>0)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('The User is already in use');", true);
            }
            else if (txtsurname.Text == "" && txtfirstname.Text == "" && txtposition.Text == "" && txtPassword.Text == "" && txtusername.Text == "")
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Please FIll all the Fields');", true);
            }
            else
            {
                Person.AddNewUser(txtfirstname.Text, txtsurname.Text, dropUsertype.Text,txtposition.Text, dropInstitution.Text,txtusername.Text,txtPassword.Text);
                ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('System User Added Successfully');", true);
            }
            
        }

        protected void revEdituserbtn_Click(object sender, EventArgs e)
        {
            GridViewRow row = RevuserGridView.SelectedRow;
            txtfirstname.Text = row.Cells[1].Text;
        }

        protected void allSystemUser_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            RevuserGridView.DataSource = Person.GetAllUsers();
            RevuserGridView.DataBind();
        }

        protected void RevuserGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = RevuserGridView.SelectedRow;
            txtfirstname.Text = row.Cells[1].Text;
            txtsurname.Text = row.Cells[2].Text;
            dropUsertype.Text = row.Cells[3].Text;
            txtposition.Text = row.Cells[4].Text;
            dropInstitution.Text = row.Cells[5].Text;
=======
            using (SqlConnection conn = new SqlConnection(DBConnects.GetconnRev()))
            {

            }
>>>>>>> bbfc6b1ce73b25c1e7d2fe94e76beb752ea9ac5f
        }
    }
}