using Microsoft.Reporting.WebForms;
using NRB_Revenue.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace NRB_Revenue
{
    public partial class Advanced : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnreportsearch_Click(object sender, EventArgs e)
        {
            ReportViewer1.ProcessingMode = ProcessingMode.Local;
            ReportViewer1.LocalReport.ReportPath = Server.MapPath(@"Reports\RevenueReport.rdlc");
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", Reports.GetMonthlyDataByCurrentMonth()));
            ReportViewer1.LocalReport.EnableHyperlinks = true;
        }
    }
}