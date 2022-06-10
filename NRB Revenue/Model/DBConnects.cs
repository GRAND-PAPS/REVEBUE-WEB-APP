using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace NRB_Revenue.Model
{
    public class DBConnects
    {
        public static string GetConnection()
        {
            string connection = ConfigurationManager.ConnectionStrings["Development"].ToString();
            return connection;
        }
    }
}