using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades
{
    class dBLogic
    {
        //Global variables. 
            //public static string con = "Data Source= Wadson; Initial Catalog=dbInventario; integraded security= true";
            private static string dataSource = "Data Source= Wadson;";
            private static string dB = "Initial Catalog=dbInventario;";
            private static string security = "Integraded security= true";
            public static string con= dataSource + dB + security;

            SqlConnection sqlCon = new SqlConnection();
            SqlCommand cmd;
            SqlDataAdapter adap;
        //End of all Global variable 

        public dBLogic() {
            sqlCon.ConnectionString = con; 
        }
        public void open() {
            try
            {
                sqlCon.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error opening connection connection :" + e.Message);
            }
        }
        public void close() {
            sqlCon.Close();
        }
        public DataSet RunCommand(string intructions) {
            DataSet result = new DataSet();
            try {
                open();
                cmd = new SqlCommand(intructions);
                cmd.Connection = sqlCon;
                cmd.ExecuteNonQuery();
                adap= new SqlDataAdapter(cmd);
                adap.Fill(result);

            } catch (Exception e) {
                Console.WriteLine("Error runing instructions" + e.Message); 
            }
            finally{
                if (sqlCon.State == ConnectionState.Open) close(); 
            }
            return result; 
        }
    }
}
