using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CShard_3cs2_Lad_P2_Salary
{
    class MyConnect
    {
        static SqlConnection connect=new SqlConnection();
        public static SqlConnection Connected()
        {
            try
            {
                String path = "Data Source=DELL-INSPIRON-1;Initial Catalog=db_Salary;User ID=Khamphay;Password=1234";
                connect.ConnectionString = path;
                if (connect.State==ConnectionState.Open)
                {
                    connect.Close();
                }
                connect.Open();
                return connect;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
