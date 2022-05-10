using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL
{
    public partial class Form1 : Form
    {
        public int sec = 3;
        Random rnd = new Random();
        int result;
        int num1;
        int num2;
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add(sec);

            num1 = rnd.Next(0, 5);
            num2 = rnd.Next(0, 6);

            labelN1.Text = num1.ToString();
            labelN2.Text = num2.ToString();

            result = num1 + num2 ;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Remove(sec);
            sec--;
            listBox1.Items.Add(sec);

            if (sec == 0)
            {
                timer1.Enabled = false;
                labelResult.Text = "너 바보구나";
            }
          
        }


        private void KeyDownResult(object sender, KeyEventArgs e)
        {

            result = (int)e.KeyCode - 48;
            

            if (result==(num1+num2))
            {
                timer1.Enabled = false;
                labelResult.Text = "너 천재구나";

  
            }
            else
            {
                timer1.Enabled = false;
                labelResult.Text = " 너 바보구나";
            }

            
        }
    }
}
