namespace bms
{
    partial class frm_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_main));
            this.lbl_head = new System.Windows.Forms.Label();
            this.cmd_temp = new System.Windows.Forms.Button();
            this.cmd_light = new System.Windows.Forms.Button();
            this.cmd_report = new System.Windows.Forms.Button();
            this.cmd_set = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_head
            // 
            this.lbl_head.AutoSize = true;
            this.lbl_head.BackColor = System.Drawing.Color.Transparent;
            this.lbl_head.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_head.ForeColor = System.Drawing.Color.White;
            this.lbl_head.Location = new System.Drawing.Point(135, 37);
            this.lbl_head.Name = "lbl_head";
            this.lbl_head.Size = new System.Drawing.Size(433, 36);
            this.lbl_head.TabIndex = 0;
            this.lbl_head.Text = "Car Controlling System";
            // 
            // cmd_temp
            // 
            this.cmd_temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_temp.Location = new System.Drawing.Point(12, 90);
            this.cmd_temp.Name = "cmd_temp";
            this.cmd_temp.Size = new System.Drawing.Size(179, 46);
            this.cmd_temp.TabIndex = 2;
            this.cmd_temp.Text = "Control";
            this.cmd_temp.UseVisualStyleBackColor = true;
            this.cmd_temp.Click += new System.EventHandler(this.cmd_temp_Click);
            // 
            // cmd_light
            // 
            this.cmd_light.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_light.Location = new System.Drawing.Point(12, 142);
            this.cmd_light.Name = "cmd_light";
            this.cmd_light.Size = new System.Drawing.Size(179, 46);
            this.cmd_light.TabIndex = 3;
            this.cmd_light.Text = "Light / Temperature";
            this.cmd_light.UseVisualStyleBackColor = true;
            this.cmd_light.Click += new System.EventHandler(this.cmd_light_Click);
            // 
            // cmd_report
            // 
            this.cmd_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_report.Location = new System.Drawing.Point(12, 194);
            this.cmd_report.Name = "cmd_report";
            this.cmd_report.Size = new System.Drawing.Size(179, 46);
            this.cmd_report.TabIndex = 4;
            this.cmd_report.Text = "Reporting";
            this.cmd_report.UseVisualStyleBackColor = true;
            this.cmd_report.Click += new System.EventHandler(this.cmd_report_Click);
            // 
            // cmd_set
            // 
            this.cmd_set.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_set.Location = new System.Drawing.Point(12, 246);
            this.cmd_set.Name = "cmd_set";
            this.cmd_set.Size = new System.Drawing.Size(179, 46);
            this.cmd_set.TabIndex = 5;
            this.cmd_set.Text = "Settings";
            this.cmd_set.UseVisualStyleBackColor = true;
            this.cmd_set.Click += new System.EventHandler(this.cmd_set_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 46);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exit!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(669, 351);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmd_set);
            this.Controls.Add(this.cmd_report);
            this.Controls.Add(this.cmd_light);
            this.Controls.Add(this.cmd_temp);
            this.Controls.Add(this.lbl_head);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CCS";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_head;
        private System.Windows.Forms.Button cmd_temp;
        private System.Windows.Forms.Button cmd_light;
        private System.Windows.Forms.Button cmd_report;
        private System.Windows.Forms.Button cmd_set;
        private System.Windows.Forms.Button button1;
    }
}

