using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NRB_Revenue.QueryBank
{
    public class ReportQuery
    {
        public string GetWeeklyReport()
        {
            string query = "";
            return query;
        }
        public static string GetMonthlyReport()
        {
            string query = "select convert(date,DateOfUpload,113) as Date, datename(WEEKDAY,convert(date,DateOfUpload,113)) as Days, " +
                "sum(case when ReasonForReplacement=1 then 2500 else 0 end) as Damaged, sum(case when ReasonForReplacement=2 then 2500 else 0 end) as Defaced, " +
                "sum(case when ReasonForReplacement=3 then 2500 else 0 end) as Expired, sum(case when ReasonForReplacement=4 then 5000 else 0 end) as NameChange, " +
                "sum(case when ReasonForReplacement=5 then 2500 else 0 end) as OtherInformationChange, " +
                "sum(case when ReasonForReplacement=6 then 2500 else 0 end) as Lost from person " +
                "where ReasonForReplacement between 1 and 6 and year(convert(date,DateOfUpload,113))=YEAR(convert(date,getdate(),113)) " +
                "and MONTH(convert(date,dateofupload,113))=1 group by convert(date,DateOfUpload,113) order by convert(date,DateOfUpload,113)";
            return query;
        }
    }
}