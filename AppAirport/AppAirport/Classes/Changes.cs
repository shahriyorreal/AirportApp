using AppAirport.Forms;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAirport.Classes
{
    public class Changes
    {
       
        public FormRegistration1 ColorButtonfrmR1(object sender, string name, FormRegistration1 frmR=null)
        {
            try
            {
                Guna2Button guna2Button = sender as Guna2Button;
                if (guna2Button.FillColor == Color.Green)
                {
                    if (frmR == null)
                    {
                        frmR = new FormRegistration1();
                    }
                    
                    guna2Button.FillColor = Color.Red;
                    frmR.Show();
                    if (name == "1.1")
                    {
                        frmR.CallsButton1();
                    }
                    else if (name == "1.2")
                    {
                        frmR.CallsButton2();
                    }
                }
                else
                {
                    frmR = new FormRegistration1();
                    guna2Button.FillColor = Color.Green;
                    frmR.Clear();
                }
                return frmR;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return frmR;
        }


        public FormRegistration2 ColorButtonfrmR2(object sender, string name, FormRegistration2 frmR2 = null)
        {
            try
            {
                Guna2Button guna2Button = sender as Guna2Button;
                if (guna2Button.FillColor == Color.Green)
                {
                    if (frmR2 == null)
                    {
                        frmR2 = new FormRegistration2();
                    }

                    guna2Button.FillColor = Color.Red;
                    frmR2.Show();
                    if (name == "2.1")
                    {
                        frmR2.CallsButton1();
                    }
                    else if (name == "2.2")
                    {
                        frmR2.CallsButton2();
                    }
                }
                else
                {
                    guna2Button.FillColor = Color.Green;
                    frmR2.Clear();
                }
                return frmR2;
            }
            catch (Exception)
            { }
            return frmR2;
        }

        FormRegistration3 frmR3;
        public void ColorButtonfrmR3(object sender)
        {
            try
            {
                Guna2Button guna2Button = sender as Guna2Button;
                if (guna2Button.FillColor == Color.Green)
                {
                    frmR3 = new FormRegistration3();
                    guna2Button.FillColor = Color.Red;
                    frmR3.Show();
                }
                else
                {
                    guna2Button.FillColor = Color.Green;
                    frmR3.Clear();
                    frmR3.Close();
                }
            }
            catch (Exception)
            { }

        }

        FormRegistration4 frmR4;
        public void ColorButtonfrmR4(object sender)
        {
            try
            {
                Guna2Button guna2Button = sender as Guna2Button;
                if (guna2Button.FillColor == Color.Green)
                {
                    frmR4 = new FormRegistration4();
                    guna2Button.FillColor = Color.Red;
                    frmR4.Show();
                }
                else
                {
                    guna2Button.FillColor = Color.Green;
                    frmR4.Clear();
                    frmR4.Close();
                }
            }
            catch (Exception)
            { }

        }
        FormRegistration5 frmR5;
        public void ColorButtonfrmR5(object sender)
        {
            try
            {
                Guna2Button guna2Button = sender as Guna2Button;
                if (guna2Button.FillColor == Color.Green)
                {
                    frmR5 = new FormRegistration5();
                    guna2Button.FillColor = Color.Red;
                    frmR5.Show();
                }
                else
                {
                    guna2Button.FillColor = Color.Green;
                    frmR5.Clear();
                    frmR5.Close();
                }
            }
            catch (Exception)
            { }

        }
    }
}
