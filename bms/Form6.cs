using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;

namespace bms
{
    public partial class Form6 : Form
    {
       
        public Form6()
        {
            InitializeComponent();
            
            if (arduinoport.IsOpen == false)
                arduinoport.Open();
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
        }

        private void Form6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.NumPad8)
            {
             
               arduinoport.Write("8");
               pictureBox1.Show();
              
            }
            else if (e.KeyCode == Keys.NumPad2)
            { 
                arduinoport.Write("2");
                pictureBox4.Show();
            }
            else if (e.KeyCode == Keys.NumPad7)
            { arduinoport.Write("7");
            pictureBox1.Show();
            pictureBox3.Show();
          
            }
            else if (e.KeyCode == Keys.NumPad9)
            { arduinoport.Write("9");
            pictureBox1.Show();
            pictureBox2.Show();
          
            }
            else if (e.KeyCode == Keys.NumPad4)
            {
                arduinoport.Write("4");
                
                pictureBox3.Show();

            }
            else if (e.KeyCode == Keys.NumPad6)
            {
                arduinoport.Write("6");
               
                pictureBox2.Show();

            }
            else if (e.KeyCode == Keys.NumPad1)
            {
                arduinoport.Write("1");
                pictureBox4.Show();
                pictureBox3.Show();

            }
            else if (e.KeyCode == Keys.NumPad3)
            {
                arduinoport.Write("3");
                pictureBox4.Show();
                pictureBox2.Show();

            }
            else { arduinoport.Write("5");
          
            }
        }

        private void Form6_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form6_KeyUp(object sender, KeyEventArgs e)
        {
            arduinoport.Write("o");
            pictureBox1.Hide();
            pictureBox2.Hide();
            pictureBox3.Hide();
            pictureBox4.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void cmd_back_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frm_main fm = new frm_main();
            fm.Show();
            arduinoport.Close();
            this.Close();
            
        }
    }
}
