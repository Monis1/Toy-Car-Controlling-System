using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;

namespace bms
{
    public partial class frm_light : Form
    {
        Thread read_temp_light, readweather,savedata;
        public static string date, time;
        public double intensity, volt;
        private OleDbConnection connect = new OleDbConnection();
    
       public static SerialPort arduinoport1;
        public frm_light()
        {
            InitializeComponent();
            arduinoport1 = arduinoport;
            
        }
        void read_temperature()
        {
            while (true)
            {
                lbl_intemp.Text = "";
                lbl_intensity.Text = "";
                
                string[] output = null;
                try
                {
                    arduinoport.Write("a");


                    string lig_temp = arduinoport.ReadLine();
                    output = lig_temp.Split(',');

                    lbl_intemp.Text = output[0];

                    lbl_intensity.Text = output[1];


                   
                }
                catch { }

           Thread.Sleep(frm_set.frequency* 1000);
            }
        }
        void request()
        {
            weather w1 = new weather();
            while (true)
            {
                lbl_outtemp.Text = "";
                try
                {
                    w1.request();
                    lbl_outtemp.Text = w1.tempC;
                    
                }
                catch { }
                Thread.Sleep(1800* 1000);
            }
        }
        
       void save_todatabse()
        {
        while(true)
        {
            try
            {
                Insert_temperature(Convert.ToDouble(lbl_intemp.Text), Convert.ToDouble(lbl_outtemp.Text));
                Insert_light(Convert.ToDouble(lbl_intensity.Text));
            }
            catch
            {}
                Thread.Sleep(300*1000);

        }
        
        
        }

        private void frm_light_Load(object sender, EventArgs e)
        {
            connect_to_database();

            read_temp_light = new Thread(read_temperature);
            readweather = new Thread(request);
            savedata = new Thread(save_todatabse);
            savedata.Start();
            readweather.Start();
            read_temp_light.Start();
           

        }

        void connect_to_database()
        {
            connect.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Monis\Desktop\Database.accdb;Persist Security Info=False;";
            try
            {
                connect.Open();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
                connect.Close();
            }
        }

        private void cmd_back_Click(object sender, EventArgs e)
        {
            frm_main fm = new frm_main();
            fm.Show();
            arduinoport.Close();
            this.Close();
        }
        void Insert_temperature(double a, double b)
        {
            string c, d;
            string[] dt = DateTime.Now.Date.ToString().Split(' ');
            c = dt[0];
            d = DateTime.Now.ToShortTimeString().ToString();

            OleDbCommand command = new OleDbCommand("INSERT INTO [Temperature]([Room_Temp], [Karachi_Temp], [Date], [Time]) VALUES(@a,@b,@c,@d)", connect);
            command.Connection = connect;
            if (connect.State == ConnectionState.Open)
            {
                command.Parameters.Add("@a", OleDbType.Double).Value = a;
                command.Parameters.Add("@b", OleDbType.Double).Value = b;
                command.Parameters.Add("@c", OleDbType.Date.ToString()).Value = c;
                command.Parameters.Add("@d", OleDbType.DBTime.ToString()).Value = d;
                try
                {
                    command.ExecuteNonQuery();
                 
                }
                catch (OleDbException expe)
                {
                    MessageBox.Show(expe.Message);
                    connect.Close();
                }
            }
        }

        void Insert_light(double volt)
        {
            string[] dt = DateTime.Now.Date.ToString().Split(' ');
            double e,d;
            string a, b,c;
            a = dt[0];
            b = DateTime.Now.ToShortTimeString().ToString();
            if (volt>0.01)
            {
                c = "Bright";
            }
            else
            { c = "Dark"; }
            d = 0.0;
            e = volt;

            OleDbCommand command = new OleDbCommand("INSERT INTO [Light]([Date], [Time], [State], [Intensity], [Voltage]) VALUES(@a,@b,@c,@d,@e)", connect);
            command.Connection = connect;
            if (connect.State == ConnectionState.Open)
            {
                command.Parameters.Add("@a", OleDbType.Date.ToString()).Value = a;
                command.Parameters.Add("@b", OleDbType.DBTime.ToString()).Value = b;
                command.Parameters.Add("@c", OleDbType.Char.ToString()).Value = c;
                command.Parameters.Add("@d", OleDbType.Double).Value = d;
                command.Parameters.Add("@e", OleDbType.Double).Value = e;
                
                
                try
                {
                    command.ExecuteNonQuery();
                   
                }
                catch (OleDbException expe)
                {
                    MessageBox.Show(expe.Message);
                    connect.Close();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void enable_CheckedChanged(object sender, EventArgs e)
        {
            if (enable.Checked == true && arduinoport.IsOpen == false)
            {
                try { arduinoport.Open(); }
                catch (Exception er)
                {
                    MessageBox.Show(er.Message, "Error");
                }
            }
            else
                arduinoport.Close();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
