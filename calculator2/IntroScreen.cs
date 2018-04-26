using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator2
{
    public partial class IntroScreen : Form
    {
        public IntroScreen()
        {
           
            InitializeComponent();
          
        }

        private void IntroScreen_Load(object sender, EventArgs e)
        {

          
        }

        private void IntroScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            
         }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(30);
            if(progressBar1.Value== 100)
            {
                timer1.Stop();
                this.Hide();
                Form1 form = new Form1();
                form.Show();             
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
