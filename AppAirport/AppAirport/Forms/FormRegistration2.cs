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
    public partial class FormRegistration2 : Form
    {
        public static FormRegistration2 formRegistration2;
        public FormRegistration2()
        {
            InitializeComponent();
            formRegistration2 = this;
        }

        public void Clear()
        {
            label2.Text = "Direction";
            label4.Text = "NumberFlight";
        }

        public void CallsButton1()
        {
            Operatorr oper = Operatorr.Operator;
            var fly = oper.Flights.FirstOrDefault();
            if (fly != null)
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


        private void FormRegistration2_Load(object sender, EventArgs e)
        {

        }
    }
}
