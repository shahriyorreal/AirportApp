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

namespace AppAirport.Forms
{
    public partial class Form1 : Form
    {
        Repository data = new Repository();
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Refresh()
        {
            Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 300000;//5 minutes
            timer1.Tick += new System.EventHandler(timer1_Tick);
            timer1.Start();
        }
        

        private void timer1_Tick(object sender, EventArgs e)
        {
            //do whatever you want 
            
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            flightlist();
        }

        private void flightlist()
        {
            data.Open();
            string sql = ("SELECT * FROM flightime");
            var get = data.Get(sql);
            Show_dgv.DataSource = get;
            DataGridEdits();
            data.Close();
        }

        private void DataGridEdits()
        {
            Show_dgv.Columns["id"].Visible = false;
            Show_dgv.Columns["DateSchedule"].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm:ss";
            Show_dgv.Columns["ActualyTime"].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm:ss";
            for (int i = 0; i < Show_dgv.Rows.Count; i++)
            {
                Show_dgv.Rows[i].Cells[1].Style.ForeColor = Color.FromArgb(255, 193, 2);
            }
            for (int i = 0; i < Show_dgv.Rows.Count; i++)
            {
                Show_dgv.Rows[i].Cells[7].Style.ForeColor = Color.FromArgb(255, 193, 2);
            }
        }
        public void ShowInstanceAsTerminated()
        {
            
        }


        private void Show_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
