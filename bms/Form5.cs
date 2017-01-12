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
    public partial class frm_set : Form
    {
        public static int frequency = 1;
        SerialPort arduinoport;
        public frm_set()
        {
            InitializeComponent();
            arduinoport = frm_light.arduinoport1;
            getserialports();
        }
        private void getserialports()
        {
            string[] ports = SerialPort.GetPortNames();
            for (int i = 0; i < ports.Length; i++)
            {
                cbox_com.Items.Add(ports[i]);
            }

        }
        private void cmd_back_Click(object sender, EventArgs e)
        {
            frm_main fm = new frm_main();
            fm.Show();
            this.Close();
        }

        private void frm_set_Load(object sender, EventArgs e)
        {

        }


        private void cbox_com_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!cbox_com.Text.Contains("com"))
            { cbox_com.Text = ""; }
            else
            { arduinoport.PortName = cbox_com.Text.ToString(); }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            arduinoport.BaudRate = int.Parse(textBox1.Text);
        }

        private void fre_TextChanged(object sender, EventArgs e)
        {
            try
            {
                frequency = int.Parse(fre.Text);
            }
            catch (Exception er)
            { MessageBox.Show(er.Message, "ERROR"); }
        }
    }
}
