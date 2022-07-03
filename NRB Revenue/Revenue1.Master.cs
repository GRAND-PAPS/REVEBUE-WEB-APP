using NRB_Revenue.Model;
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
            
        }
    }
}