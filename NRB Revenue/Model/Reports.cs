using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using NRB_Revenue.QueryBank;

namespace NRB_Revenue.Model
{
    public class Reports
    {
        public static DataTable GetMonthlyReport()
        {
            DataTable Dt = new DataTable();
            using (SqlConnection con = new SqlConnection(DBConnects.GetConnection()))
            {
                SqlDataAdapter Adp = new SqlDataAdapter(ReportQuery.GetMonthlyReport(), DBConnects.GetConnection());
                Adp.Fill(Dt);
            }
            return Dt;
        }

    }
}