using AppAirport.Classes;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAirport.Forms
{
    public partial class Operatorr : Form
    {
        public static Operatorr Operator;
        Repository data = new Repository();

        public List<OperatorRegistration> Flights = new List<OperatorRegistration>() { };
        public Operatorr()
        {
            InitializeComponent();
            flightlist();
            Operator = this;
        }
        private void flightlist()
        {
            data.Open();
            string sql = ("SELECT * From flightime");
            var get = data.Get(sql);
            guna2DataGridView1.DataSource = get;
            guna2DataGridView1.Columns["id"].Visible = false;
            guna2DataGridView1.Columns["DateSchedule"].DefaultCellStyle.Format = "yyyy/dd/MM HH:mm:ss";
            guna2DataGridView1.Columns["ActualyTime"].DefaultCellStyle.Format = "yyyy/dd/MM HH:mm:ss";
            data.Close();
        }
        bool isCopyed = false;
        private void guna2DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Flights != null)
            {
                Flights.Clear();
            }
            Flights.Add(
                new OperatorRegistration()
                {
                    Id = int.Parse(guna2DataGridView1.Rows[e.RowIndex].Cells["id"].Value.ToString()),
                    ActualyTime = DateTime.Parse(guna2DataGridView1.SelectedRows[0].Cells["ActualyTime"].Value.ToString()),
                    Direction = guna2DataGridView1.SelectedRows[0].Cells["Direction"].Value.ToString(),
                    Status = guna2DataGridView1.SelectedRows[0].Cells["Status"].Value.ToString(),
                    NumberFlight = int.Parse(guna2DataGridView1.SelectedRows[0].Cells["NumberFlight"].Value.ToString()),
                    Aviacompany = guna2DataGridView1.SelectedRows[0].Cells["Aviacompany"].Value.ToString(),
                    TypeFlights = guna2DataGridView1.SelectedRows[0].Cells["TypeFlights"].Value.ToString(),
                    DateSchule = DateTime.Parse(guna2DataGridView1.SelectedRows[0].Cells["DateSchedule"].Value.ToString())
                }
                );
            isCopyed = true;
        }

        private void SaveToDb()
        {
            foreach (var item in Flights)
            {
                data.Open();
                var dateSchule = item.DateSchule.ToString("yyyy-MM-dd HH:mm:ss");
                var actualyTime = item.ActualyTime.ToString("yyyy-MM-dd HH:mm:ss");
                string sql = "INSERT INTO registration (DateSchedule, NumberFlight, Aviacompany, Direction, Status, TypeFlights, ActualyTime) VALUES('" + dateSchule + "', '" + item.NumberFlight + "', '" + item.Aviacompany + "', '" + item.Direction + "', '" + item.Status + "', '" + item.TypeFlights + "', '" + actualyTime + "')";
                data.InsertUpdate(sql);
                data.Close();
            }
        }
        FormRegistration1 frmmm;
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (isCopyed == true)
            {
                Changes changes = new Changes();
                frmmm = changes.ColorButtonfrmR1(sender, "1.1", frmmm);
            }
            else
            {
                MessageBox.Show("Error");
            }
            
        }
        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (isCopyed == true)
            {
                Changes changes = new Changes();
                changes.ColorButtonfrmR1(sender, "1.2", frmmm);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        FormRegistration2 frmmm2;
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (isCopyed == true)
            {
                Changes changes = new Changes();
                changes.ColorButtonfrmR2(sender, "2.1", frmmm2);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            if (isCopyed == true)
            {
                Changes changes = new Changes();
                changes.ColorButtonfrmR3(sender);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            if (isCopyed == true)
            {
                Changes changes = new Changes();
                changes.ColorButtonfrmR4(sender);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            if (isCopyed == true)
            {
                Changes changes = new Changes();
                changes.ColorButtonfrmR5(sender);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //button 2.2
            if (isCopyed == true)
            {
                Changes changes = new Changes();
                changes.ColorButtonfrmR2(sender, "2.2", frmmm2);
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }

}
