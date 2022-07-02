using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NRB_Revenue.QueryBank
{
    public class Users
    {
        public static string GetUserByUserName(string user)
        {
            string query = "select UserID, FirstName, Surname, UserType, Position, Institution, Username from RevUser where Username='" + user + "'";
            return query;
        }
        public static string AddNewUser(string fname,string sname,string utype, string position, string institution, string uname, string pwd )
        {
            string query = "insert into RevUser values('" + fname + "','" + sname + "','" + utype + "','" + position + "','" + institution + "','" + uname + "','" + pwd + "')";
            return query;
        }
        public static string GetAllUsers()
        {
            string query = "select UserID, FirstName, Surname, UserType, Position, Institution, Username from RevUser";
            return query;
        }
        public static string GetLoginUser(string username,string password)
        {
            string query = "select * from RevUser where Username='"+username+"' and Password='"+password+"'";
            return query;
        }
    }
}