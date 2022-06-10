using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NRB_Revenue.QueryBank
{
    public class RevenueQueries
    {
        public static string GetWeeklyData()
        {
            string query = "select datename(WEEKDAY,convert(date,DateOfUpload,113)) as Days, " +
                "convert(date,DateOfUpload,113) as DateUploaded, count(*) as Total from Person " +
                "where datepart(ww, DateOfUpload)=02 and YEAR(DateOfUpload)=year(GETDATE()) " +
                "group by datename(WEEKDAY,convert(date,DateOfUpload,113))," +
                "convert(Date,DateOfUpload,113) order by convert(Date,DateOfUpload,113)";
            return query;
        }
    }
}