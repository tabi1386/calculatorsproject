using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        //double enterFirstValue, enterSecondValue;
      //  string op;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          

        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button num = (Button)sender;
            if (txtResult.Text == "0")
                txtResult.Text = "";
            {
                if (num.Text == ".")
                {
                    if (!txtResult.Text.Contains("."))

                        txtResult.Text = txtResult.Text + num.Text;

                }
                else
                {
                    txtResult.Text = txtResult.Text + num.Text;
                }
            }
        }

        private void numberOper(object sender, EventArgs e)
        {
            Button num = (Button)sender;

            if (txtResult.Text.Length == 0) return;

            char lastchar = txtResult.Text[txtResult.Text.Length - 1];
            if ("+_*/".Contains(lastchar)) return;
            txtResult.Text += num.Text;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
              try
            {
                DataTable dt = new DataTable();
                var result = dt.Compute(txtResult.Text, "");
                txtResult.Text = result.ToString();
            }
            catch
            {
                MessageBox.Show("عبارت نامعتبر است");
            }
            
        }
         

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
        }

        /*  private void btnClearEntry_Click(object sender, EventArgs e)
          {
              txtResult.Text = "0";

              string f, s;
              f = Convert.ToString(enterFirstValue);
              s = Convert.ToString(enterSecondValue);
              f = "";
              s = "";
          }*/

        private void btnPM_Click(object sender, EventArgs e)
        {
            double q = Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(-1 * q);
        }

        private void btnBs_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length>0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }
            if (txtResult.Text =="")
            {
                txtResult.Text ="0";
            }
        }
    }
}
