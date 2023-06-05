using AppAirport.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAirport.UserControls
{
    public partial class LIstFlights : UserControl
    {
        Repository data = new Repository();
        public LIstFlights()
        {
            InitializeComponent();
            flightlist();
        }


        private void flightlist()
        {
            data.Open();
            string sql = ("SELECT * From flightime");
            var get = data.Get(sql);
            guna2DataGridView1.DataSource = get;
            guna2DataGridView1.Columns["id"].Visible = false;
            data.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
        }
         
    }
}
