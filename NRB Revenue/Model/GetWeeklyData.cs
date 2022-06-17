using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using NRB_Revenue.QueryBank;
using NRB_Revenue.Model;

namespace NRB_Revenue.Model
{
    public class GetWeeklyData
    {
        public static DataTable DisplayRecord()
        {
            DataTable Dt = new DataTable();
            using(SqlConnection con = new SqlConnection(DBConnects.GetConnection()))
            {
                SqlDataAdapter Adp = new SqlDataAdapter(RevenueQueries.GetWeeklyData(), DBConnects.GetConnection());                
                Adp.Fill(Dt);
            }
            return Dt;
        }
    }
}