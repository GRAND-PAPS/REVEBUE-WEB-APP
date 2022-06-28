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
            using (SqlConnection conn = new SqlConnection(DBConnects.GetconnRev()))
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandText = cmd.CommandText;
                cmd.CommandText = "select UserID, FirstName, Surname, UserType, Position, Institution, Username from RevUser where Username='" + searchtxtbox.Text+"'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable(); 
                SqlDataAdapter adpt = new SqlDataAdapter(cmd);
                adpt.Fill(dt);

                if(searchtxtbox.Text=="")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Please fill the Text Box Search..!!!!');", true);

                }else if(dt.Rows.Count == 0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('There is No System User with that Name');", true);

                }
                else
                {
                    RevuserGridView.DataSource = dt;
                    RevuserGridView.DataBind();
                }
                

                conn.Close();
            }
                

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        protected void btnsubimt_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DBConnects.GetconnRev()))
            {
                string query = "select FirstName, Surname, Username from RevUser where FirstName='" + txtusername.Text + "'";
                SqlDataAdapter sqldata = new SqlDataAdapter(query, conn);
                DataTable systuser = new DataTable();
                sqldata.Fill(systuser);

                if(systuser.Rows.Count > 0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('The User is already in use');", true);
                }
                else if (txtsurname.Text == "" && txtfirstname.Text=="" && txtposition.Text=="" && txtPassword.Text == "" && txtusername.Text=="")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Please FIll all the Fields');", true);
                }
                else
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("insert into RevUser values('"+txtfirstname.Text+"','"+txtsurname.Text+"','"+dropUsertype.Text+"','"+txtposition.Text+"','"+dropInstitution.Text+"','"+txtusername.Text+"','"+txtPassword.Text+"')", conn);
                    cmd.Connection = conn;
                    cmd.ExecuteNonQuery();
                    conn.Close();

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", "alert('System User Added Successfully');", true);
                }
            }
        }

        protected void revEdituserbtn_Click(object sender, EventArgs e)
        {

        }

        protected void allSystemUser_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DBConnects.GetconnRev()))
            {

            }
        }
    }
}