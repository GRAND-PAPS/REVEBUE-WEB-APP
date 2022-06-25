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
            if(!IsPostBack)
            {
                allreports.Enabled = false;
                txtreportdatestart.Enabled = false;
                txtreportdateend.Enabled = false;
                districtdroplist.Enabled = false;
                districtdroplist2.Enabled = false;

            }
            
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

            districtdroplist2.Items.Clear();
            districtdroplist2.Items.Add("SELECT DISTRICTS");

            districtdroplist2.DataSource = Districts.GetDistricts();
            districtdroplist2.DataBind();
        }

        protected void btnreportsearch_Click(object sender, EventArgs e)
        {
            if (reportRadioButton2.Checked == true)
            {
                ReportViewer1.ProcessingMode = ProcessingMode.Local;
                ReportViewer1.LocalReport.ReportPath = Server.MapPath(@"Reports\DistrictReport.rdlc");
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", Reports.GetMonthlyReport()));
                ReportViewer1.LocalReport.EnableHyperlinks = true;

                //using (SqlConnection con = new SqlConnection(DBConnects.GetConnection()))
                //{
                //    if (con.State == ConnectionState.Closed) { con.Open(); };
                //    using (SqlCommand cmd = new SqlCommand(RevenueQueries.GetMonthlyReportByDates(districtdroplist2.SelectedValue.ToString(), txtreportdatestart.Text, txtreportdateend.Text), con))
                //    {
                //        SqlDataReader dr = cmd.ExecuteReader();
                //        if (dr.Read())
                //        {
                //            DataTable dt = new DataTable();
                //            dt.Load(dr);

                //            ReportViewer1.ProcessingMode = ProcessingMode.Local;
                //            ReportViewer1.LocalReport.ReportPath = Server.MapPath(@"Reports\DistrictReport.rdlc");
                //            ReportViewer1.LocalReport.DataSources.Clear();
                //            ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
                //            ReportViewer1.LocalReport.EnableHyperlinks = true;

                //        }
                //    }
                //}
            }
            else if(reportRadioButton1.Checked==true)
            {
                if(allreports.SelectedValue.ToString()== "Monthly Report")
                {

                }
            }
        }
    }
}