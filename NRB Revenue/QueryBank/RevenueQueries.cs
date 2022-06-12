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
        public static string GetMonthlyRevenue()
        {
            string query = "select  datename(MONTH,convert(date,DateOfUpload,113)) as Months, " +
                "sum(case when ReasonForReplacement in (1,2,3,5,6) then 2500 else 5000 end) as Total from Person " +
                "where YEAR(DateOfUpload)=year(GETDATE()) and ReasonForReplacement between 1 and 6 " +
                "group by datename(MONTH,convert(date,DateOfUpload,113)),DATEPART(MONTH,CONVERT(date,dateofupload,113)) " +
                "order by DATEPART(MONTH,CONVERT(date,dateofupload,113)) asc";
            return query;
        }
    }
}