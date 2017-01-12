namespace bms
{
    partial class frm_report
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_search_time = new System.Windows.Forms.Button();
            this.btn_search_date = new System.Windows.Forms.Button();
            this.dtpick_Date = new System.Windows.Forms.DateTimePicker();
            this.dtpick_Time = new System.Windows.Forms.DateTimePicker();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomTempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.karachiTempDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.intensityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.voltageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet3 = new bms.DatabaseDataSet3();
            this.finalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet2 = new bms.DatabaseDataSet2();
            this.finalTableAdapter = new bms.DatabaseDataSet2TableAdapters.FinalTableAdapter();
            this.finalTableAdapter1 = new bms.DatabaseDataSet3TableAdapters.FinalTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search_time
            // 
            this.btn_search_time.Location = new System.Drawing.Point(498, 122);
            this.btn_search_time.Name = "btn_search_time";
            this.btn_search_time.Size = new System.Drawing.Size(117, 34);
            this.btn_search_time.TabIndex = 1;
            this.btn_search_time.Text = "Search";
            this.btn_search_time.UseVisualStyleBackColor = true;
            this.btn_search_time.Click += new System.EventHandler(this.btn_search_time_Click);
            // 
            // btn_search_date
            // 
            this.btn_search_date.Location = new System.Drawing.Point(498, 204);
            this.btn_search_date.Name = "btn_search_date";
            this.btn_search_date.Size = new System.Drawing.Size(117, 34);
            this.btn_search_date.TabIndex = 5;
            this.btn_search_date.Text = "Search";
            this.btn_search_date.UseVisualStyleBackColor = true;
            this.btn_search_date.Click += new System.EventHandler(this.btn_search_date_Click);
            // 
            // dtpick_Date
            // 
            this.dtpick_Date.Location = new System.Drawing.Point(432, 178);
            this.dtpick_Date.Name = "dtpick_Date";
            this.dtpick_Date.Size = new System.Drawing.Size(183, 20);
            this.dtpick_Date.TabIndex = 6;
            this.dtpick_Date.Value = new System.DateTime(2014, 11, 30, 0, 56, 20, 0);
            // 
            // dtpick_Time
            // 
            this.dtpick_Time.Location = new System.Drawing.Point(432, 96);
            this.dtpick_Time.Name = "dtpick_Time";
            this.dtpick_Time.Size = new System.Drawing.Size(183, 20);
            this.dtpick_Time.TabIndex = 7;
            this.dtpick_Time.Value = new System.DateTime(2014, 11, 30, 0, 56, 2, 0);
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(516, 279);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(141, 23);
            this.btn_show.TabIndex = 10;
            this.btn_show.Text = "Show all data";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(369, 279);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(141, 23);
            this.btn_clear.TabIndex = 11;
            this.btn_clear.Text = "Clear all data";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Search by Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Search by Date";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(369, 308);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(288, 31);
            this.btn_back.TabIndex = 15;
            this.btn_back.Text = "Back to Main Menu";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sNoDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.roomTempDataGridViewTextBoxColumn,
            this.karachiTempDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.intensityDataGridViewTextBoxColumn,
            this.voltageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.finalBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(351, 327);
            this.dataGridView1.TabIndex = 16;
            // 
            // sNoDataGridViewTextBoxColumn
            // 
            this.sNoDataGridViewTextBoxColumn.DataPropertyName = "S_No";
            this.sNoDataGridViewTextBoxColumn.HeaderText = "S_No";
            this.sNoDataGridViewTextBoxColumn.Name = "sNoDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Time";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // roomTempDataGridViewTextBoxColumn
            // 
            this.roomTempDataGridViewTextBoxColumn.DataPropertyName = "Room_Temp";
            this.roomTempDataGridViewTextBoxColumn.HeaderText = "Room_Temp";
            this.roomTempDataGridViewTextBoxColumn.Name = "roomTempDataGridViewTextBoxColumn";
            // 
            // karachiTempDataGridViewTextBoxColumn
            // 
            this.karachiTempDataGridViewTextBoxColumn.DataPropertyName = "Karachi_Temp";
            this.karachiTempDataGridViewTextBoxColumn.HeaderText = "Karachi_Temp";
            this.karachiTempDataGridViewTextBoxColumn.Name = "karachiTempDataGridViewTextBoxColumn";
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            // 
            // intensityDataGridViewTextBoxColumn
            // 
            this.intensityDataGridViewTextBoxColumn.DataPropertyName = "Intensity";
            this.intensityDataGridViewTextBoxColumn.HeaderText = "Intensity";
            this.intensityDataGridViewTextBoxColumn.Name = "intensityDataGridViewTextBoxColumn";
            // 
            // voltageDataGridViewTextBoxColumn
            // 
            this.voltageDataGridViewTextBoxColumn.DataPropertyName = "Voltage";
            this.voltageDataGridViewTextBoxColumn.HeaderText = "Voltage";
            this.voltageDataGridViewTextBoxColumn.Name = "voltageDataGridViewTextBoxColumn";
            // 
            // finalBindingSource1
            // 
            this.finalBindingSource1.DataMember = "Final";
            this.finalBindingSource1.DataSource = this.databaseDataSet3;
            // 
            // databaseDataSet3
            // 
            this.databaseDataSet3.DataSetName = "DatabaseDataSet3";
            this.databaseDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // finalBindingSource
            // 
            this.finalBindingSource.DataMember = "Final";
            this.finalBindingSource.DataSource = this.databaseDataSet2;
            // 
            // databaseDataSet2
            // 
            this.databaseDataSet2.DataSetName = "DatabaseDataSet2";
            this.databaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // finalTableAdapter
            // 
            this.finalTableAdapter.ClearBeforeFill = true;
            // 
            // finalTableAdapter1
            // 
            this.finalTableAdapter1.ClearBeforeFill = true;
            // 
            // frm_report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 351);
            this.ControlBox = false;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.dtpick_Time);
            this.Controls.Add(this.dtpick_Date);
            this.Controls.Add(this.btn_search_date);
            this.Controls.Add(this.btn_search_time);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CCS-Reporting";
            this.Load += new System.EventHandler(this.frm_report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search_time;
        private System.Windows.Forms.Button btn_search_date;
        private System.Windows.Forms.DateTimePicker dtpick_Date;
        private System.Windows.Forms.DateTimePicker dtpick_Time;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseDataSet2 databaseDataSet2;
        private System.Windows.Forms.BindingSource finalBindingSource;
        private DatabaseDataSet2TableAdapters.FinalTableAdapter finalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn sNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomTempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn karachiTempDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn intensityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn voltageDataGridViewTextBoxColumn;
        private DatabaseDataSet3 databaseDataSet3;
        private System.Windows.Forms.BindingSource finalBindingSource1;
        private DatabaseDataSet3TableAdapters.FinalTableAdapter finalTableAdapter1;
    }
}