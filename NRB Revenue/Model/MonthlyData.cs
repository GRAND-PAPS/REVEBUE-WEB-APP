using NRB_Revenue.QueryBank;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace NRB_Revenue.Model
{
    public class MonthlyData
    {
        public static DataTable GetMonthlyData()
        {
            DataTable Dt = new DataTable();
            using (SqlConnection con = new SqlConnection(DBConnects.GetConnection()))
            {
                SqlDataAdapter Adp = new SqlDataAdapter(RevenueQueries.GetMonthlyRevenue(), DBConnects.GetConnection());
                Adp.Fill(Dt);
            }
            return Dt;
        }
    }
}