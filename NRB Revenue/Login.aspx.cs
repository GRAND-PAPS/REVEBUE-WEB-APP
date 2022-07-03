using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
<<<<<<< HEAD
using System.Data.SqlClient;
using NRB_Revenue.QueryBank;
using System.Data;
=======
>>>>>>> f2863c6df2eac4c1b213e3fa98bfd99d15718a9a

namespace NRB_Revenue
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Loginbtn_Click(object sender, EventArgs e)
        {

<<<<<<< HEAD
            Authenticateuser();
        }

        void Authenticateuser()
        {
            string user = LoginUsername.Text, pwd = LoginPassword.Text;
            try
            {
                if (Person.GetLogedUser(user, pwd).Rows.Count == 0)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Script", "alert('There is No System User with that Name');", true);
                }
                else
                {
                    UserDetails.Username = user;
                    Response.Redirect("~/dashboard.aspx");
                }
            }
            catch
            {


            }
=======
>>>>>>> f2863c6df2eac4c1b213e3fa98bfd99d15718a9a
        }
    }
}