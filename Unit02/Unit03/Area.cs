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

namespace Area
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCir.Checked==true)
            {
                txtRadius.Visible = true;
                txtArea.Visible = false;
                txtWidth.Visible = false;
                txtSide.Visible = false;
                txtHeight.Visible = false;
            }
            else
            {
                txtArea.Visible = true;
                txtWidth.Visible = true;
                txtSide.Visible = true;
                txtHeight.Visible = true;
            }
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            txtArea.Visible = true;
            if (rdbCir.Checked == true)
            {
                String rString;
                int r;
                rString = txtRadius.Text;
                r = int.Parse(rString);
                double areaCir = (3.14) * (r * r);
                txtArea.Text = areaCir.ToString();
            }
            else if (rdbSqu.Checked == true)
            {
                String sString;
                int s;
                sString = txtSide.Text;
                s = int.Parse(sString);
                double areaSqu = (s*s);
                txtArea.Text = areaSqu.ToString();
            }
            else if (rdbRec.Checked == true)
            {
                String hString;
                int h;
                String wString;
                int w;
                hString = txtHeight.Text;
                h = int.Parse(hString);
                wString = txtWidth.Text;
                w = int.Parse(wString);
                double areaRec = (h * w);
                txtArea.Text = areaRec.ToString();
            }


        }

        private void rdbSqu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSqu.Checked == true)
            {
                txtSide.Visible = true;
                txtArea.Visible = false;
                txtWidth.Visible = false;
                txtHeight.Visible = false;
                txtRadius.Visible = false;                
            }
            else
            {
                txtArea.Visible = true;
                txtWidth.Visible = true;
                txtHeight.Visible = true;
                txtRadius.Visible = true;
            }
        }

        private void rdbRec_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRec.Checked == true)
            {
                txtHeight.Visible = true;
                txtSide.Visible = false;
                txtWidth.Visible = true;
                txtArea.Visible = false;
                txtRadius.Visible = false;
            }
            else
            {
                txtArea.Visible = true;
                txtSide.Visible = true;
                txtRadius.Visible = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtArea.Clear();
            txtHeight.Clear();
            txtRadius.Clear();
            txtSide.Clear();
            txtWidth.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
