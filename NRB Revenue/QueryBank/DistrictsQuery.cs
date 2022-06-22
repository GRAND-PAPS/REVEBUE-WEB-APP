using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NRB_Revenue.QueryBank
{
    public class DistrictsQuery
    {
        public static string GetAllDistricts()
        {
            string query = "select * from district where districtid>0 order by name";
            return query;
        }
    }
}