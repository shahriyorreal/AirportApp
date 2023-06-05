using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace AppAirport.Classes
{
    class Repository
    {
        MySqlConnection myconn = new MySqlConnection();
        private string constr = "server=localhost; username=root; password =;DATABASE=airport;";

        public void InsertUpdate(string query)
        {
            MySqlCommand command = new MySqlCommand(query, myconn);
            command.ExecuteNonQuery();
        }

        public DataTable Get(string query)
        {
            MySqlDataAdapter mydata = new MySqlDataAdapter(query, myconn);
            DataTable dtable = new DataTable();
            mydata.Fill(dtable);
            return dtable;
        }

        public bool Open()
        {
            try
            {
                myconn.ConnectionString = constr;
                myconn.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
        public void Close()
        {
            myconn.Close();
        }
    }

    
}
