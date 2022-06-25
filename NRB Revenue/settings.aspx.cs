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

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        protected void btnsubimt_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(DBConnects.GetconnRev()))
            {
                string query = "select Username from RevUser where Username='" + txtusername.Text + "'";
                SqlDataAdapter sqldata = new SqlDataAdapter(query, conn);
                DataTable systuser = new DataTable();
                sqldata.Fill(systuser);

                if(systuser.Rows.Count > 0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('Username is already in use');", true);
                }
                //else if(txtsurname.Text =="" && txtPassword.Text=="")
            }
        }
    }
}