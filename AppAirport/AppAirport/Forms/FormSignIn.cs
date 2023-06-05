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
    public partial class FormSignIn : Form
    {
        public FormSignIn()
        {
            InitializeComponent();
            Transparents();
            
        }

        public void Transparents()
        {
            guna2Button1.Parent = guna2GradientPanel1;
            guna2Button1.BackColor = Color.Transparent;
            label1.Parent = guna2GradientPanel1;
            label1.BackColor = Color.Transparent;
            txtUsername.Parent = guna2GradientPanel1;
            txtUsername.BackColor = Color.Transparent;
            txtPassword.Parent = guna2GradientPanel1;
            txtPassword.BackColor = Color.Transparent;
            guna2GradientPanel1.Parent = guna2PictureBox1;
            guna2GradientPanel1.BackColor = Color.FromArgb(25, guna2GradientPanel1.BackColor);
            guna2CircleButton1.Parent = guna2PictureBox1;
            guna2CircleButton1.BackColor = Color.Transparent;
        }

        

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Auth auth = new Auth();
                var user = auth.IsExist(txtUsername.Text, txtPassword.Text);
                if (user.Exist)
                {
                    if (user.Roless == Roles.admin)
                    {
                        var show = new AdminPanel();
                        show.user = user;
                        show.Show();
                    }
                    else if(user.Roless == Roles.staff)
                    {
                        var show = new Form1();
                        show.Show();
                    }
                    else if(user.Roless == Roles.regis)
                    {
                        var show = new FormRegistration1();
                        show.Show();
                    }
                    else
                    {
                        var show = new Operatorr();
                        show.Show();

                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception){ } 
        }

        private void guna2Button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                guna2Button1.PerformClick();
                // these last two lines will stop the beep sound
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
        }
    }
}
