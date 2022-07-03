using Microsoft.Reporting.WebForms;
using NRB_Revenue.Model;
using NRB_Revenue.QueryBank;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NRB_Revenue
{
    public partial class report : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            allreports.Enabled = false;
            txtreportdatestart.Enabled = false;
            txtreportdateend.Enabled = false;
            districtdroplist.Enabled = false;
            districtdroplist2.Enabled = false;

            districtdroplist2.DataSource = Districts.GetDistricts();
            districtdroplist2.DataBind();
        }
        protected void reportRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            allreports.Enabled = true;
            districtdroplist.Enabled = true;
        }

        protected void reportRadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            districtdroplist2.Enabled = true;
            txtreportdatestart.Enabled = true;
            txtreportdateend.Enabled = true;
        }

        protected void btnreportsearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(DBConnects.GetConnection()))
            {
                if (con.State == ConnectionState.Closed) { con.Open(); };
                using (SqlCommand cmd = new SqlCommand(ReportQuery.GetMonthlyReport(), con))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(dr);
                        ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                        ReportViewer1.LocalReport.EnableHyperlinks = true;

                    }
                }
            }
        }
    }
}