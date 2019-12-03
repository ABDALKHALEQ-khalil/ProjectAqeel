using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace projectAqeeel.Code
{
    class Employees
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        public DataTable GetAllEmployee()
        {
            dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("GetAllEmployee", null);
            dal.Close();
            return dt;
            
        }

        public DataTable SearchEmployee(string name )
        {
            dal.Open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[0].Value = name;

            dt = dal.SelectData("SearchEmployee", param);
            dal.Close();
            return dt;
        }

        public void AddEmployee(string name ,string address , int Phone , int salary )
        {
            dal.Open();
           
            SqlParameter[] param = new SqlParameter[4];

            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[0].Value = name;

            param[1] = new SqlParameter("@address", SqlDbType.NVarChar, 50);
            param[1].Value = address;

            param[2] = new SqlParameter("@Phone", SqlDbType.Int, 50);
            param[2].Value = Phone;

            param[3] = new SqlParameter("@salary", SqlDbType.Int, 50);
            param[3].Value = salary;

            dal.ExecuteCommand("AddEmployee", param);
            dal.Close();
          
        }
        public void DeleteEmployee(int id )
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = id;
            dal.ExecuteCommand("DeleteEmployee",param);
            dal.Close();
        }
    }
}
