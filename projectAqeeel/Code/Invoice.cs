using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace projectAqeeel.Code
{
    class Invoice
    {
        DAL.DataAccessLayer dal = new DAL.DataAccessLayer();
        public Invoice()
            {
                
            }

        public DataTable GetAllCustomer ()
        {
            dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("GetAllCustomer", null);
            dal.Close();
            return dt;
        }
        
        public DataTable SelectGoods(string name)
        {
            dal.Open();
            DataTable dt = new DataTable();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Good", SqlDbType.NVarChar, 50);
            param[0].Value = name;
            dt = dal.SelectData("selectGoods", param);
            dal.Close();
            return dt;
        }

        public DataTable SearchCustomer(string name)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];

            param[0] = new SqlParameter("@name", SqlDbType.NVarChar, 50);
            param[0].Value = name;

            DataTable dt = new DataTable();
            dt = dal.SelectData("SearchCustomer", param);
            dal.Close();
            return dt;
        }
        public DataTable Quantity(string name)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@NameGoods", SqlDbType.NVarChar, 50);
            param[0].Value = name;

            DataTable dt = new DataTable();
            dt = dal.SelectData("QuantityIsHer", param);
            dal.Close();
            return dt;
            
        }
        public DataTable GoodsPrice(string name)
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@NameGoods", SqlDbType.NVarChar, 50);
            param[0].Value = name;

            DataTable dt = new DataTable();
            dt = dal.SelectData("GoodsPrice", param);
            dal.Close();
            return dt;
        }


        public DataTable GetAllNameGoods()
        {
            dal.Open();
            DataTable dt = new DataTable();
            dt = dal.SelectData("GetAllNameGoods", null);
            dal.Close();
            return dt;
        }
        public DataTable AddInvoice(string nameCustomer , string nameGood ,int qunatity , int unitPrice , int discount )
        {
            dal.Open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@nameCustomer", SqlDbType.NVarChar, 50);
            param[0].Value = nameCustomer;

            param[1] = new SqlParameter("@nameGoods", SqlDbType.NVarChar, 50);
            param[1].Value = nameGood;
         
            param[2] = new SqlParameter("@Price", SqlDbType.Int);
            param[2].Value = unitPrice;

            param[3] = new SqlParameter("@Quantity", SqlDbType.Int);
            param[3].Value = qunatity;

            param[4] = new SqlParameter("@Discount", SqlDbType.Int);
            param[4].Value =discount;

            param[5] = new SqlParameter("@UserName", SqlDbType.NVarChar, 50);
            param[5].Value = UserInfo.username;

            DataTable dt = new DataTable();
            dt = dal.SelectData("AddInvoice", param);
            dal.Close();
            return dt;
        }


    }
}
