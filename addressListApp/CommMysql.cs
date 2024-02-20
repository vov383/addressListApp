using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

using MySql.Data.MySqlClient;

namespace Dawool
{
    class CommMysql
    {
        private static string ConnectionString()
        {
             return @"SERVER=192.168.0.180;DATABASE=employee_list;UID=root;PASSWORD=dw#1234;"; 
        }

        #region [Method] ExecuteDataSet
        public static DataSet ExecuteDataSet(string sbSql)
        {
            DataSet ds = new DataSet();
            

            string connectionString = ConnectionString();
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter();

                string commandText = sbSql;
                MySqlCommand cmd = new MySqlCommand(commandText, conn);

                adapter.SelectCommand = cmd;
                adapter.Fill(ds, "rtn_table");
                conn.Close();
                return ds;
            }
            catch (MySqlException ex)
            {
                //MessageBox.Show("DATABASE 연결이 되지 않습니다. 다시 확인해 주세요.");
                //Environment.Exit(-1);

                throw new Exception(ex.Message);
            }

        }
        #endregion
            
        #region [Method] ExecuteNonQueryc
        public static int ExecuteNonQuery(string sbSql)
        {
            int intRtn = -1;
            DataSet ds = new DataSet();

            string connectionString = ConnectionString();
            MySqlConnection conn = new MySqlConnection(connectionString);
            try
            {
                conn.Open();

                string commandText = sbSql;
                MySqlCommand cmd = new MySqlCommand(commandText, conn);

                intRtn = cmd.ExecuteNonQuery();
                conn.Close();
                return intRtn;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("DATABASE 연결이 되지 않습니다. 다시 확인해 주세요.");
                Environment.Exit(-1);
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}
