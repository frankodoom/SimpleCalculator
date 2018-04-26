using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Calculator Memory
        List<double> M = new List<double>();
        //holds the current operation
        string operation = "";
        //Current computed value
        double ans = 0;
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void close3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
            txtDisplay.Text = "0";
            txtDisplay.ReadOnly = true;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Clear();
                txtDisplay.AppendText("1");
                txtInput.AppendText("1");
                M.Add(Convert.ToInt32(txtDisplay.Text));
            }
            else
            {
                txtDisplay.Clear();
                txtDisplay.AppendText("1");
                M.Add(Convert.ToInt32(txtDisplay.Text));
                txtInput.AppendText("1");

            }


        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Clear();
                txtDisplay.AppendText("2");
                txtInput.AppendText("2");
                M.Add(Convert.ToDouble(txtDisplay.Text));
            }
            else
            {
                txtDisplay.Clear();
                txtDisplay.AppendText("2");
                txtInput.AppendText("2");
                M.Add(Convert.ToDouble(txtDisplay.Text));
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Clear();
                txtDisplay.AppendText("3");
                txtInput.AppendText("3");
                M.Add(Convert.ToDouble(txtDisplay.Text));
            }
            else
            {
                txtDisplay.Clear();
                txtDisplay.AppendText("3");
                txtInput.AppendText("3");
                M.Add(Convert.ToDouble(txtDisplay.Text));
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Clear();
                txtDisplay.AppendText("4");
                txtInput.AppendText("4");
                M.Add(Convert.ToDouble(txtDisplay.Text));
            }
            else
            {
                txtDisplay.Clear();
                txtDisplay.AppendText("4");
                txtInput.AppendText("4");
                M.Add(Convert.ToDouble(txtDisplay.Text));
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Clear();
                txtDisplay.AppendText("5");
                txtInput.AppendText("5");
                M.Add(Convert.ToDouble(txtDisplay.Text));
            }
            else
            {
                txtDisplay.Clear();
                txtDisplay.AppendText("5");
                txtInput.AppendText("5");
                M.Add(Convert.ToDouble(txtDisplay.Text));
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Clear();
                txtDisplay.AppendText("6");
                txtInput.AppendText("6");
                M.Add(Convert.ToDouble(txtDisplay.Text));
            }
            else
            {
                txtDisplay.Clear();
                txtDisplay.AppendText("6");
                txtInput.AppendText("6");
                M.Add(Convert.ToDouble(txtDisplay.Text));
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Clear();
                txtInput.AppendText("7");
                txtDisplay.AppendText("7");
                M.Add(Convert.ToDouble(txtDisplay.Text));
            }
            else
            {
                txtDisplay.Clear();
                txtDisplay.AppendText("7");
                txtInput.AppendText("7");
                M.Add(Convert.ToDouble(txtDisplay.Text));
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Clear();
                txtInput.AppendText("8");
                txtDisplay.AppendText("8");
                M.Add(Convert.ToDouble(txtDisplay.Text));
            }
            else
            {
                txtDisplay.Clear();
                txtDisplay.AppendText("8");
                txtInput.AppendText("8");
                M.Add(Convert.ToDouble(txtDisplay.Text));
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Clear();
                txtInput.AppendText("9");
                txtDisplay.AppendText("9");
                M.Add(Convert.ToDouble(txtDisplay.Text));
            }
            else
            {
                txtDisplay.Clear();
                txtDisplay.AppendText("9");
                txtInput.AppendText("9");
                M.Add(Convert.ToDouble(txtDisplay.Text));
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {

                txtDisplay.AppendText("0");
                txtInput.AppendText("0");
                M.Add(Convert.ToDouble(txtDisplay.Text));
         
        }

        private void btnClearEverything_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            txtInput.Clear();
            txtDisplay.Text = "0";
            M.Clear();
            ans =0;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // get the  length of text in display
            var length = txtDisplay.TextLength;
            if (length >0)
            {
                var recentDisplay = txtDisplay.Text.Substring(0, length - 1);
                txtDisplay.Text = recentDisplay;
            }
            else if(length <= 0)
            {
                txtDisplay.Text = "0";
            }         
        }

        
        
        private void btnSum_Click(object sender, EventArgs e)
        {

            txtInput.AppendText("+");
            operation = "+";
 

        }
        private void btnEquals_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    if(M.Count == 0)
                    {
                        ans = ans + Convert.ToInt32(txtDisplay.Text);
                    }
                    else
                    {
                        foreach (var item in M)
                        {
                            ans = item + ans;
                        }
                        M.Clear();
                     
                    }                  
                    break;

                case "-":
                    if (M.Count == 0)
                    {
                        ans = ans - Convert.ToInt32(txtDisplay.Text);
                    }
                    else
                    {
                        foreach (var item in M)
                        {
                            ans = ans -item;
                        }
                        M.Clear();
                  
                    }
                    break;

                case "*":
                    if (M.Count == 0)
                    {
                        ans = ans - Convert.ToInt32(txtDisplay.Text);
                    }
                    else
                    {
                        foreach (var item in M)
                        {
                            ans = ans * item;
                        }
                        M.Clear();

                    }
                    break;

                case "/":
                    if (M.Count == 0)
                    {
                        ans = ans / Convert.ToInt32(txtDisplay.Text);
                    }
                    else
                    {
                        foreach (var item in M)
                        {
                            ans = ans / item;
                        }
                        M.Clear();

                    }
                    break;
                default:
                    break;
            }
           

            txtDisplay.Text = ans.ToString();
           // ans = 0;
            M.Clear();
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtDisplay.AppendText(".");
            txtInput.AppendText(".");
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtInput.AppendText("*");
            operation = "*";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            txtInput.AppendText("-");
            operation = "-";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            txtInput.AppendText("/");
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }
}
