/****************************************************
  Boobin Choi
  Lab #3
*****************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Convert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void convt_Click(object sender, EventArgs e)
        {
            if (rdbF.Checked == true && !string.IsNullOrEmpty(this.txtF.Text))
            {
                String fString;
                int f;
                fString = txtF.Text;
                f = int.Parse(fString);
                double c = (f - 32.0) * (5.0 / 9.0);
                txtC.Visible = true;
                txtC.Text = c.ToString();
            }
            else
            {
                if (rdbC.Checked == true && !string.IsNullOrEmpty(this.txtC.Text))
                {
                    String cString;
                    int c;
                    cString = txtC.Text;
                    c = int.Parse(cString);
                    double f = (c * 9.0 / 5.0) + (32.0);
                    txtF.Visible = true;
                    txtF.Text = f.ToString();
                }
                else
                {
                    MessageBox.Show("You forgot to put the tempuerature!");
                }
            }

        }

        private void ex_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure you want to Exit?");
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtF.Clear();
            txtC.Clear();
        }

        private void rdbF_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbF.Checked)
            {
                this.Text = "Fahrenheit to Celsius";
                txtC.Visible = false;
            }
            else
            {
                this.Text = "Celsius to Fahrenheit";
                txtC.Visible = true;
            }

        }

        private void rdbC_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbC.Checked)
            {
                this.Text = "Celsius to Fahrenheit";
                txtF.Visible = false;
            }
            else
            {
                this.Text = "Fahrenheit to Celsius";
                txtF.Visible = true;
            }
        }
    }
}
