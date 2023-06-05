using AppAirport.Classes;
using AppAirport.UserControls;
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
    public partial class AdminPanel : Form
    {
        public User user = new User();
        public AdminPanel()
        {
            InitializeComponent();
        }
        private void AddUserControl(UserControl usercontrol)
        {
            usercontrol.Dock = DockStyle.Fill;
            guna2Panel2.Controls.Clear();
            guna2Panel2.Controls.Add(usercontrol);
            usercontrol.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            var MyControl = new LIstFlights();
            AddUserControl(MyControl);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            var MyControl = new AddFlights();
            AddUserControl(MyControl);
        }
    }
}
