using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace projectAqeeel.Code
{
    class Customers
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();

        public void addCustomer(string name , double phone , string Email)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[3];

            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[0].Value = name;

            param[1] = new SqlParameter("@numberPhone", SqlDbType.Int);
            param[1].Value = phone;

            param[2] = new SqlParameter("@email", SqlDbType.NVarChar, 50);
            param[2].Value = Email;

            dal.ExecuteCommand("addCustomer", param);
            dal.Close();



        }
        public DataTable CustomerIsHere(string name)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@userName", SqlDbType.NVarChar, 50);
            param[0].Value = name;

            DataTable dt = new DataTable();
            dt = dal.SelectData("CustomerIsher", param);
            dal.Close();
            return dt;

        }
        
        public DataTable CustomerIsHere()
        {
            dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("CustomerIsher", null);
            dal.Close();
            return dt;

        }
    }
}
