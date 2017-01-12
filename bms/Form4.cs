using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bms
{
    public partial class frm_report : Form
    {
        private OleDbConnection connect = new OleDbConnection();
        public frm_report()
        {
            InitializeComponent();
        }

        private void frm_report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet3.Final' table. You can move, or remove it, as needed.
            this.finalTableAdapter1.Fill(this.databaseDataSet3.Final);
            dtpick_Time.Format = DateTimePickerFormat.Custom;
            dtpick_Time.CustomFormat = "hh:mm tt";
            dtpick_Time.ShowUpDown = true;

            dtpick_Date.Format = DateTimePickerFormat.Custom;
            dtpick_Date.CustomFormat = "dd MMM yyyy";

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

        private void btn_search_time_Click(object sender, EventArgs e)
        {
            DataSet ds1 = new DataSet();
            OleDbDataAdapter adpSearch = new OleDbDataAdapter();
            adpSearch.SelectCommand = new OleDbCommand();
            adpSearch.SelectCommand.Connection = connect;
            adpSearch.SelectCommand.CommandText = "select Temperature.S_No, Temperature.Date, Temperature.Time, Temperature.Room_Temp, Temperature.Karachi_Temp, Light.State, Light.Intensity, Light.Voltage FROM Temperature INNER JOIN Light ON Temperature.S_No = Light.S_No Where Temperature.Time = #" + dtpick_Time.Text + "#";  
            adpSearch.SelectCommand.Parameters.AddWithValue("@Time", dtpick_Time.Text);
            adpSearch.Fill(ds1, dtpick_Time.Text.ToString());
            dataGridView1.DataSource = ds1;
            dataGridView1.DataMember = dtpick_Time.Text.ToString();
        }

        private void btn_search_date_Click(object sender, EventArgs e)
        {
            DataSet ds1 = new DataSet();
            OleDbDataAdapter adpSearch = new OleDbDataAdapter();
            adpSearch.SelectCommand = new OleDbCommand();
            adpSearch.SelectCommand.Connection = connect;
            adpSearch.SelectCommand.CommandText = "select Temperature.S_No, Temperature.Date, Temperature.Time, Temperature.Room_Temp, Temperature.Karachi_Temp, Light.State, Light.Intensity, Light.Voltage FROM Temperature INNER JOIN Light ON Temperature.S_No = Light.S_No Where Temperature.Date = #" + dtpick_Date.Text + "#";
            adpSearch.SelectCommand.Parameters.AddWithValue("@Date", dtpick_Date.Text.ToString());
            adpSearch.Fill(ds1, dtpick_Date.Text.ToString());
            dataGridView1.DataSource = ds1;
            dataGridView1.DataMember = dtpick_Date.Text.ToString();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'databaseDataSet1.Final' table. You can move, or remove it, as needed.
            this.finalTableAdapter1.Fill(this.databaseDataSet3.Final);
            OleDbCommand Comm = new OleDbCommand();
            OleDbDataReader reader;
            Comm.Connection = connect;
            Comm.CommandText = "select Temperature.S_No, Temperature.Date, Temperature.Time, Temperature.Room_Temp, Temperature.Karachi_Temp, Light.State, Light.Intensity, Light.Voltage FROM Temperature INNER JOIN Light ON Temperature.S_No = Light.S_No";
            reader = Comm.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            if (dt.Rows.Count > 0)
            {
                string temp = dt.Rows[0][2].ToString();
                dataGridView1.DataSource = dt;
                
            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            frm_main f1 = new frm_main();
            f1.Show();
            this.Close();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
        }
    }
}
