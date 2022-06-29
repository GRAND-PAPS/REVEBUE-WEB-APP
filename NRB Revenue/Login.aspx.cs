using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using NRB_Revenue.Model;
using NRB_Revenue.QueryBank;
using System.Data;

namespace NRB_Revenue
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Loginbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(DBConnects.GetconnRev()))
            {
                string query = "select * from RevUser where Username='"+LoginUsername.Text+"' and Password='"+LoginPassword.Text+"'";
                SqlDataAdapter sqlData = new SqlDataAdapter(query, cn);
                DataTable RevT = new DataTable();
                sqlData.Fill(RevT);

                if(RevT.Rows.Count > 0)
                {

                }
            }
        }
    }
}