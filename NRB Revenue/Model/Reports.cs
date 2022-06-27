﻿using System;
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
                SqlDataAdapter Adp = new SqlDataAdapter(ReportQuery.GetMonthlyReport(), con);
                Adp.Fill(Dt);
            }
            return Dt;
        }
        public static DataTable GetMonthlyReportByDistrictsandDates(string district,string sdate,string edate)
        {
            DataTable Dt = new DataTable();
            using (SqlConnection con = new SqlConnection(DBConnects.GetConnection()))
            {
                SqlDataAdapter Adp = new SqlDataAdapter(RevenueQueries.GetMonthlyReportByDates(district, sdate, edate), con);
                Adp.Fill(Dt);
            }
            return Dt;
        }
        public static DataTable GetMonthlyReportByDistricts(string district)
        {
            DataTable Dt = new DataTable();
            using (SqlConnection con = new SqlConnection(DBConnects.GetConnection()))
            {
                SqlDataAdapter Adp = new SqlDataAdapter(RevenueQueries.GetMonthlyReportByDistrict(district), con);
                Adp.Fill(Dt);
            }
            return Dt;
        }
        public static DataTable GetMonthlyDataByCurrentMonth()
        {
            DataTable Dt = new DataTable();
            using (SqlConnection con = new SqlConnection(DBConnects.GetConnection()))
            {
                SqlDataAdapter Adp = new SqlDataAdapter(RevenueQueries.GetMonthlyDataByCurrentMonth(), con);
                Adp.Fill(Dt);
            }
            return Dt;
        }
    }
}