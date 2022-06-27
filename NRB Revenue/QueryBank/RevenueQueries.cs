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
            string query = "select datename(MONTH, convert(date, DateOfUpload, 113)) as Months, " +
                "sum(case when ReasonForReplacement = 1 then 2500 else 0 end) as Damaged, " +
                "sum(case when ReasonForReplacement = 2 then 2500 else 0 end) as Defaced, " +
                "sum(case when ReasonForReplacement = 3 then 2500 else 0 end) as Expired, " +
                "sum(case when ReasonForReplacement = 4 then 5000 else 0 end) as NameChange, " +
                "sum(case when ReasonForReplacement = 5 then 2500 else 0 end) as OtherChages, " +
                "sum(case when ReasonForReplacement = 6 then 2500 else 0 end) as Lost  " +
                "from Person where YEAR(DateOfUpload) = year(GETDATE()) and ReasonForReplacement between 1 and 6 " +
                "group by datename(MONTH, convert(date, DateOfUpload, 113)),DATEPART(MONTH, CONVERT(date, dateofupload, 113)) " +
                "order by DATEPART(MONTH, CONVERT(date, dateofupload, 113)) asc";
            return query;
        }
        public static string GetMonthlyReportByDates(string District, string StartDate, string EndDate)
        {
            string query = "select upper(datename(MONTH,convert(date,DateOfUpload,113))) as Months, d.Name as District, " +
                "sum(case when ReasonForReplacement = 1 then 2500 else 0 end) as Damaged, " +
                "sum(case when ReasonForReplacement = 2 then 2500 else 0 end) as Defaced, " +
                "sum(case when ReasonForReplacement = 3 then 2500 else 0 end) as Expired, " +
                "sum(case when ReasonForReplacement = 4 then 5000 else 0 end) as NameChange, " +
                "sum(case when ReasonForReplacement = 5 then 2500 else 0 end) as OtherChanges, " +
                "sum(case when ReasonForReplacement = 6 then 2500 else 0 end) as Lost " +
                "from Person p join Village v  on v.VillageId = p.PlaceOfRegistrationId " +
                "join Section s on s.SectionId = v.SectionId join Chiefdom c on c.ChiefdomId = s.ChiefdomId " +
                "join District d on d.DistrictId = c.DistrictId where DateOfUpload BETWEEN '"+StartDate+"' AND '"+EndDate+"' " +
                "and ReasonForReplacement between 1 and 6 and d.Name = '"+District+"' " +
                "group by d.Name, datename(MONTH, convert(date, DateOfUpload, 113)), DATEPART(month, DateOfUpload) " +
                "order by DATEPART(month, DateOfUpload)";
            return query;
        }
        public static string GetMonthlyReportByDistrict(string District)
        {
            string query = "select upper(datename(MONTH,convert(date,DateOfUpload,113))) as Months, d.Name as District, " +
                "sum(case when ReasonForReplacement = 1 then 2500 else 0 end) as Damaged, " +
                "sum(case when ReasonForReplacement = 2 then 2500 else 0 end) as Defaced, " +
                "sum(case when ReasonForReplacement = 3 then 2500 else 0 end) as Expired, " +
                "sum(case when ReasonForReplacement = 4 then 5000 else 0 end) as NameChange, " +
                "sum(case when ReasonForReplacement = 5 then 2500 else 0 end) as OtherChanges, " +
                "sum(case when ReasonForReplacement = 6 then 2500 else 0 end) as Lost " +
                "from Person p join Village v  on v.VillageId = p.PlaceOfRegistrationId " +
                "join Section s on s.SectionId = v.SectionId join Chiefdom c on c.ChiefdomId = s.ChiefdomId " +
                "join District d on d.DistrictId = c.DistrictId where ReasonForReplacement between 1 and 6 and d.Name = '" + District + "' " +
                "group by d.Name, datename(MONTH, convert(date, DateOfUpload, 113)), DATEPART(month, DateOfUpload) " +
                "order by DATEPART(month, DateOfUpload)";
            return query;
        }
    }
}