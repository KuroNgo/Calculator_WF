using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        int count;
        float num1, ans;
        private void Empty()
        {
            txtShow.Text = "";
            // Cách 2
            //txtShow.Text = string.Empty;
        }
        private void Calculator_Load(object sender, EventArgs e)
        {
            Empty();
        }

        private void btnEmpty_Click(object sender, EventArgs e)
        {
            Empty();
            count = 0;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + "9";
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtShow.Text = txtShow.Text + ".";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            compute(count);
        }
        private void compute(int count)
        {
            switch (count)
            {
                case 1:
                    ans = num1 / float.Parse(txtShow.Text);
                    if (float.Parse(txtShow.Text) != 0)
                    {
                        txtShow.Text = num1 + "/" + float.Parse(txtShow.Text) + "=" + ans.ToString();
                    }
                    break;
                case 2:
                    ans = num1 * float.Parse(txtShow.Text);
                    txtShow.Text = num1 + "x" + float.Parse(txtShow.Text) + "=" + ans.ToString();
                    break;
                case 3:
                    ans = num1 - float.Parse(txtShow.Text);
                    txtShow.Text = num1 + "-" + float.Parse(txtShow.Text) + "=" + ans.ToString();
                    break;
                case 4:
                    ans = num1 + float.Parse(txtShow.Text);
                    txtShow.Text = num1 + "+" + float.Parse(txtShow.Text) + "=" + ans.ToString();
                    break;
                default:
                    break;
            }
        }
        private void btnAdvice_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtShow.Text);
            txtShow.Clear();
            txtShow.Focus();
            count = 1;
        }

        private void btnMultiple_Click(object sender, EventArgs e)
        {
            if (txtShow.Text != "")
            {
                num1 = float.Parse(txtShow.Text);
                txtShow.Clear();
                txtShow.Focus();
                count = 2;
            }
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtShow.Text);
            txtShow.Clear();
            txtShow.Focus();
            count = 3;
        }

        private void btnEqual_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyValue == 13)
            {
                compute(count);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txtShow.Text);
            txtShow.Clear();
            txtShow.Focus();
            count = 4;
        }

    }
}
