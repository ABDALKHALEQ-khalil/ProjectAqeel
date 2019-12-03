using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace projectAqeeel.Code
{
    class supplers
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        public DataTable SearchSuppllaers(string search)
        {

            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@search", SqlDbType.NVarChar, 55);
            param[0].Value = search;
            DataTable dt = new DataTable();

            dt = dal.SelectData("SearchSuppllaers", param);
            return dt;

        }
        public DataTable GetAllSupplaers()
        {
            dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("GetAllSupplaers", null);
            dal.Close();
            return dt;
        }
        public DataTable SearchInvoiceSupplaer(int id )
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@search", SqlDbType.NVarChar, 55);
            param[0].Value = id;
            DataTable dt = new DataTable();

            dt = dal.SelectData("SearchInvoiceSupplaer", param);
            return dt;
        }

        public void AddSupplaers(string name , string cat , int phone , string address , string email)
        {
            dal.Open();

            SqlParameter[] param = new SqlParameter[5];
            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[0].Value = name;

            param[1] = new SqlParameter("@catogry", SqlDbType.NVarChar, 50);
            param[1].Value = cat;

            param[2] = new SqlParameter("@phone", SqlDbType.Int);
            param[2].Value = phone;

            param[3] = new SqlParameter("@address", SqlDbType.NVarChar, 50);
            param[3].Value = address;

            param[4] = new SqlParameter("@email", SqlDbType.NVarChar, 100);
            param[4].Value = email;

            dal.ExecuteCommand("AddSupplaers", param);
            dal.Close();
        }



    }
}
