using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using NRB_Revenue.QueryBank;

namespace NRB_Revenue.Model
{
    public class Person
    {
        public static DataTable GetUserByUserName(string _user)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter Adp = new SqlDataAdapter(Users.GetUserByUserName(_user), DBConnects.GetconnRev());
            Adp.Fill(dt);
            return dt;
        }
        public static DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter Adp = new SqlDataAdapter(Users.GetAllUsers(), DBConnects.GetconnRev());
            Adp.Fill(dt);
            return dt;
        }
        public static void AddNewUser(string firstname, string surnname, string usertype, string position, string institution, string username, string pwd)
        {
            using(SqlConnection con = new SqlConnection(DBConnects.GetconnRev()))
            {
                con.Open();
                using(SqlCommand cmd = new SqlCommand(Users.AddNewUser(firstname, surnname, usertype, position, institution, username, pwd).ToString(),con))
                {
                    cmd.ExecuteNonQuery();
                }
                con.Close();
            }
        }
        public static DataTable GetLogedUser(string user, string pass)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter Adp = new SqlDataAdapter(Users.GetLoginUser(user,pass), DBConnects.GetconnRev());
            Adp.Fill(dt);
            return dt;
        }
    }
}