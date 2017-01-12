namespace bms
{
    partial class frm_set
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
            this.lbl_set = new System.Windows.Forms.Label();
            this.cbox_com = new System.Windows.Forms.ComboBox();
            this.lbl_com = new System.Windows.Forms.Label();
            this.lbl_baud = new System.Windows.Forms.Label();
            this.cmd_back = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_set
            // 
            this.lbl_set.AutoSize = true;
            this.lbl_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_set.Location = new System.Drawing.Point(238, 26);
            this.lbl_set.Name = "lbl_set";
            this.lbl_set.Size = new System.Drawing.Size(113, 31);
            this.lbl_set.TabIndex = 0;
            this.lbl_set.Text = "Settings";
            // 
            // cbox_com
            // 
            this.cbox_com.FormattingEnabled = true;
            this.cbox_com.Location = new System.Drawing.Point(272, 102);
            this.cbox_com.Name = "cbox_com";
            this.cbox_com.Size = new System.Drawing.Size(88, 21);
            this.cbox_com.TabIndex = 2;
            this.cbox_com.SelectedIndexChanged += new System.EventHandler(this.cbox_com_SelectedIndexChanged);
            // 
            // lbl_com
            // 
            this.lbl_com.AutoSize = true;
            this.lbl_com.Location = new System.Drawing.Point(162, 105);
            this.lbl_com.Name = "lbl_com";
            this.lbl_com.Size = new System.Drawing.Size(88, 13);
            this.lbl_com.TabIndex = 3;
            this.lbl_com.Text = "Select Serial Port";
            // 
            // lbl_baud
            // 
            this.lbl_baud.AutoSize = true;
            this.lbl_baud.Location = new System.Drawing.Point(192, 162);
            this.lbl_baud.Name = "lbl_baud";
            this.lbl_baud.Size = new System.Drawing.Size(58, 13);
            this.lbl_baud.TabIndex = 4;
            this.lbl_baud.Text = "Baud Rate";
            // 
            // cmd_back
            // 
            this.cmd_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_back.Location = new System.Drawing.Point(12, 302);
            this.cmd_back.Name = "cmd_back";
            this.cmd_back.Size = new System.Drawing.Size(172, 37);
            this.cmd_back.TabIndex = 6;
            this.cmd_back.Text = "Back to Main Menu";
            this.cmd_back.UseVisualStyleBackColor = true;
            this.cmd_back.Click += new System.EventHandler(this.cmd_back_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(272, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(88, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Frequency(seconds)";
            // 
            // fre
            // 
            this.fre.Location = new System.Drawing.Point(272, 220);
            this.fre.Name = "fre";
            this.fre.Size = new System.Drawing.Size(88, 20);
            this.fre.TabIndex = 9;
            this.fre.TextChanged += new System.EventHandler(this.fre_TextChanged);
            // 
            // frm_set
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 351);
            this.ControlBox = false;
            this.Controls.Add(this.fre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cmd_back);
            this.Controls.Add(this.lbl_baud);
            this.Controls.Add(this.lbl_com);
            this.Controls.Add(this.cbox_com);
            this.Controls.Add(this.lbl_set);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_set";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CCS-Settings";
            this.Load += new System.EventHandler(this.frm_set_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_set;
        private System.Windows.Forms.ComboBox cbox_com;
        private System.Windows.Forms.Label lbl_com;
        private System.Windows.Forms.Label lbl_baud;
        private System.Windows.Forms.Button cmd_back;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fre;
    }
}