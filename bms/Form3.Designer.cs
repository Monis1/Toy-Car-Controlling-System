namespace bms
{
    partial class frm_light
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_light));
            this.cmd_back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_intemp = new System.Windows.Forms.Label();
            this.lbl_outtemp = new System.Windows.Forms.Label();
            this.lbl_intensity = new System.Windows.Forms.Label();
            this.arduinoport = new System.IO.Ports.SerialPort(this.components);
            this.enable = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // cmd_back
            // 
            this.cmd_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_back.Location = new System.Drawing.Point(12, 302);
            this.cmd_back.Name = "cmd_back";
            this.cmd_back.Size = new System.Drawing.Size(172, 37);
            this.cmd_back.TabIndex = 8;
            this.cmd_back.Text = "Back to Main Menu";
            this.cmd_back.UseVisualStyleBackColor = true;
            this.cmd_back.Click += new System.EventHandler(this.cmd_back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(25, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Location = new System.Drawing.Point(231, 68);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 200);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(143, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "°C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(353, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 36);
            this.label2.TabIndex = 13;
            this.label2.Text = "°C";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(555, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 36);
            this.label3.TabIndex = 14;
            this.label3.Text = "V";
            // 
            // lbl_intemp
            // 
            this.lbl_intemp.AutoSize = true;
            this.lbl_intemp.BackColor = System.Drawing.Color.Black;
            this.lbl_intemp.Font = new System.Drawing.Font("Digital-7 Italic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_intemp.ForeColor = System.Drawing.Color.White;
            this.lbl_intemp.Location = new System.Drawing.Point(65, 156);
            this.lbl_intemp.Name = "lbl_intemp";
            this.lbl_intemp.Size = new System.Drawing.Size(0, 28);
            this.lbl_intemp.TabIndex = 15;
            // 
            // lbl_outtemp
            // 
            this.lbl_outtemp.AutoSize = true;
            this.lbl_outtemp.BackColor = System.Drawing.Color.Black;
            this.lbl_outtemp.Font = new System.Drawing.Font("Digital-7 Italic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_outtemp.ForeColor = System.Drawing.Color.White;
            this.lbl_outtemp.Location = new System.Drawing.Point(299, 156);
            this.lbl_outtemp.Name = "lbl_outtemp";
            this.lbl_outtemp.Size = new System.Drawing.Size(0, 28);
            this.lbl_outtemp.TabIndex = 16;
            // 
            // lbl_intensity
            // 
            this.lbl_intensity.AutoSize = true;
            this.lbl_intensity.BackColor = System.Drawing.Color.Black;
            this.lbl_intensity.Font = new System.Drawing.Font("Digital-7 Italic", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_intensity.ForeColor = System.Drawing.Color.White;
            this.lbl_intensity.Location = new System.Drawing.Point(494, 156);
            this.lbl_intensity.Name = "lbl_intensity";
            this.lbl_intensity.Size = new System.Drawing.Size(0, 28);
            this.lbl_intensity.TabIndex = 17;
            // 
            // arduinoport
            // 
            this.arduinoport.PortName = "COM4";
            // 
            // enable
            // 
            this.enable.Appearance = System.Windows.Forms.Appearance.Button;
            this.enable.AutoSize = true;
            this.enable.Location = new System.Drawing.Point(26, 29);
            this.enable.Name = "enable";
            this.enable.Size = new System.Drawing.Size(89, 23);
            this.enable.TabIndex = 18;
            this.enable.Text = "Enable Arduino";
            this.enable.UseVisualStyleBackColor = true;
            this.enable.CheckedChanged += new System.EventHandler(this.enable_CheckedChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Location = new System.Drawing.Point(437, 68);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(200, 200);
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // frm_light
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 351);
            this.ControlBox = false;
            this.Controls.Add(this.enable);
            this.Controls.Add(this.lbl_intensity);
            this.Controls.Add(this.lbl_outtemp);
            this.Controls.Add(this.lbl_intemp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.cmd_back);
            this.Controls.Add(this.pictureBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_light";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CCS-Light / Temperature";
            this.Load += new System.EventHandler(this.frm_light_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_back;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_intemp;
        private System.Windows.Forms.Label lbl_outtemp;
        private System.Windows.Forms.Label lbl_intensity;
        private System.Windows.Forms.CheckBox enable;
        private System.IO.Ports.SerialPort arduinoport;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}