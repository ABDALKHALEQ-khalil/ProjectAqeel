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



    }
}
