using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bms
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {

        }

        private void cmd_temp_Click(object sender, EventArgs e)
        {
            Form6 f1 = new Form6();
            this.Hide();
            f1.Show();
          
        }

        private void cmd_light_Click(object sender, EventArgs e)
        {
            frm_light fl = new frm_light();
            this.Hide();
            fl.Show();
            
        }

        private void cmd_report_Click(object sender, EventArgs e)
        {
            frm_report fr = new frm_report();
            this.Hide();
            fr.Show();
           
        }

        private void cmd_set_Click(object sender, EventArgs e)
        {
            frm_set fs = new frm_set();
            this.Hide();
            fs.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
