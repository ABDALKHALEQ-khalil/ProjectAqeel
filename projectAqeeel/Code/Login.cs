using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace projectAqeeel.Code
{
    class Login
    {
        public DataTable GetInfoUser(string username, string password)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@username", SqlDbType.NVarChar, 50);
            param[0].Value = username;

            param[1] = new SqlParameter("@password", SqlDbType.NVarChar, 50);
            param[1].Value = password;

            DataTable dt = new DataTable();
            dt = dal.SelectData("GetInfoUser", param);

            dal.Close();
            return dt;
        }
        public DataTable isAdmin(string username)
        {
            DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@username", SqlDbType.NVarChar, 50);
            param[0].Value = username;

            DataTable dt = new DataTable();
            dt = dal.SelectData("IsAdmin", param);

            dal.Close();
            return dt;
        }
    }
}
