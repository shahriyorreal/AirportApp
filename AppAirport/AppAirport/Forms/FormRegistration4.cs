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
    public partial class FormRegistration4 : Form
    {
        public static FormRegistration4 formRegistration4;
        public FormRegistration4()
        {
            InitializeComponent();
            CallsButton1();
            formRegistration4 = this;
        }
        public void Clear()
        {
            label2.Text = "Direction";
            label4.Text = "NumberFlight";
        }

        private void CallsButton1()
        {
            Operatorr oper = Operatorr.Operator;
            var fly = oper.Flights.FirstOrDefault();
            if (fly != null)
            {
                label2.Text = fly.Direction;
                label4.Text = fly.NumberFlight.ToString();
            }

        }

        private void FormRegistration4_Load(object sender, EventArgs e)
        {

        }
    }
}
