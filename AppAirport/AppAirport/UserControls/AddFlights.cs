using AppAirport.Classes;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AppAirport.UserControls
{
    public partial class AddFlights : UserControl
    {
        MySqlConnection Mysqlcon = new MySqlConnection();
        Repository data = new Repository();
        public AddFlights()
        {
            InitializeComponent();
            
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            data.Open();
            string sql = "INSERT INTO FlighTime (DateSchedule, NumberFlight, Aviacompany, Direction, Status, TypeFlights, ActualyTime) VALUES('"+txtDateSchedule.Text+"', '"+txtNumberFlights.Text+"', '"+txtAviacompany.Text+"', '"+txtDirection.Text+"', '"+txtStatus.Text+"', '"+txtTypeFlights.Text+"', '"+txtActualyTime.Text+"')";
            data.InsertUpdate(sql);
            data.Close();
            Clearr();
        }

        private void Clearr()
        {
            txtAviacompany.Clear();
            txtDirection.Clear();
            txtNumberFlights.Clear();
            txtStatus.Clear();
            txtTypeFlights.Clear();
        }
       
    }
}
