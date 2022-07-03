using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NRB_Revenue
{
    public partial class Revenue1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
<<<<<<< HEAD
            if(!IsPostBack)
            {
                if(usernamelbl.Text== "System username")
                {
                    Response.Redirect(@"~/Login.aspx");
                }
                else
                {
                    usernamelbl.Text = UserDetails.Username;
                }
            }
            
=======

>>>>>>> f2863c6df2eac4c1b213e3fa98bfd99d15718a9a
        }
    }
}