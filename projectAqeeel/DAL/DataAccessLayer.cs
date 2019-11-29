using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace projectAqeeel.DAL
{
    class DataAccessLayer
    {
        SqlConnection sqlconneciton;

        //This Constructor Inisialize the connection object 
        public DataAccessLayer()
        {
            sqlconneciton = new SqlConnection(@"Data Source=.;Initial Catalog=ALHADDAD_FOR_TRADING;Integrated Security=True");
        }

        //Method to open the Connection 
        public void Open()
        {
           
                if (sqlconneciton.State != ConnectionState.Open)
                {
                    sqlconneciton.Open();
                }
           
        }
        //Method To Close The Connection
        public void Close()
        {
            if (sqlconneciton.State == ConnectionState.Open)
            {
                sqlconneciton.Close();
            }
        }

        //Method To Read Data From Database
        public DataTable SelectData(string stored_procedure, SqlParameter[] param)
        {
           
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = stored_procedure;
                sqlcmd.Connection = sqlconneciton;

                if (param != null)
                {
                    for (int i = 0; i < param.Length; i++)
                    {
                        sqlcmd.Parameters.Add(param[i]);
                    }
                }
                SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            
            
        }

        //Method To Insert ,update and Delete data From Database 
        public void ExecuteCommand(string stored_procedure, SqlParameter[] param)
        {
          
                SqlCommand sqlcmd = new SqlCommand();
                sqlcmd.CommandType = CommandType.StoredProcedure;
                sqlcmd.CommandText = stored_procedure;
                sqlcmd.Connection = sqlconneciton;


                if (param != null)
                {
                    sqlcmd.Parameters.AddRange(param);
                }
                sqlcmd.ExecuteNonQuery();
          
        }
    }
}
