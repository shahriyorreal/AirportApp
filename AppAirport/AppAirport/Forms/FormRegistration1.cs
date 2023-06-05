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
    public partial class FormRegistration1 : Form
    {
        public static FormRegistration1 formRegistration1;
       
        public FormRegistration1()
        {
            InitializeComponent();
            formRegistration1 = this;
        }

        public void CallsButton1()
        {
            Operatorr oper = Operatorr.Operator;
            var fly = oper.Flights.FirstOrDefault();
            if (fly != null )
            {
                label2.Text = fly.Direction;
                label4.Text = fly.NumberFlight.ToString();
            }
            
        }
        public void CallsButton2()
        {
            Operatorr oper = Operatorr.Operator;
            var fly = oper.Flights.FirstOrDefault();
            if (fly != null)
            {
                label3.Text = fly.Direction;
                label5.Text = fly.NumberFlight.ToString();
            }

        }

        public void Clear()
        {
            label2.Text = "Direction";
            label4.Text = "NumberFlight";
        }

        private void FormRegistration1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }


}
