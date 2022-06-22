using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using NRB_Revenue.QueryBank;

namespace NRB_Revenue.Model
{
    public class Districts
    {
        public static DataTable GetDistricts()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter Adp = new SqlDataAdapter(DistrictsQuery.GetAllDistricts(), DBConnects.GetConnection());
            Adp.Fill(dt);
            return dt;
        }
    }
}