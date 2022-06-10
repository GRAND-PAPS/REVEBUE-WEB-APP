using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using NRB_Revenue.Model;
using NRB_Revenue.QueryBank;

namespace NRB_Revenue
{
    public partial class dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                GetData();
            }
        }
        void GetData()
        {
            GridView1.DataSource = GetWeeklyData.DisplayRecord();
            GridView1.DataBind();

            Chart1.DataSource = GetWeeklyData.DisplayRecord();
            //Chart1.Legends[0].Enabled = true;
            Chart1.Series[0].XValueMember = "Days";
            Chart1.Series[0].YValueMembers = "Total";
            Chart1.DataBind();
        }
    }
}