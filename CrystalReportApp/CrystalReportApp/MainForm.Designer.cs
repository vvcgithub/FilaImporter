namespace CrystalReportApp
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_exit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.report_clients = new System.Windows.Forms.ComboBox();
            this.button_jv = new System.Windows.Forms.Button();
            this.button_cv = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_exit);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.report_clients);
            this.groupBox1.Controls.Add(this.button_jv);
            this.groupBox1.Controls.Add(this.button_cv);
            this.groupBox1.Location = new System.Drawing.Point(22, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 174);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Just pick a client and a report";
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(57, 136);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(189, 21);
            this.button_exit.TabIndex = 7;
            this.button_exit.Text = "CLOSE";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select A Quickbook Account";
            // 
            // report_clients
            // 
            this.report_clients.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.report_clients.FormattingEnabled = true;
            this.report_clients.Location = new System.Drawing.Point(57, 49);
            this.report_clients.Name = "report_clients";
            this.report_clients.Size = new System.Drawing.Size(189, 21);
            this.report_clients.TabIndex = 5;
            // 
            // button_jv
            // 
            this.button_jv.Location = new System.Drawing.Point(57, 108);
            this.button_jv.Name = "button_jv";
            this.button_jv.Size = new System.Drawing.Size(189, 21);
            this.button_jv.TabIndex = 4;
            this.button_jv.Text = "JOURNAL VOUCHER";
            this.button_jv.UseVisualStyleBackColor = true;
            this.button_jv.Click += new System.EventHandler(this.button_jv_Click);
            // 
            // button_cv
            // 
            this.button_cv.Location = new System.Drawing.Point(57, 79);
            this.button_cv.Name = "button_cv";
            this.button_cv.Size = new System.Drawing.Size(189, 21);
            this.button_cv.TabIndex = 3;
            this.button_cv.Text = "CHECK VOUCHER";
            this.button_cv.UseVisualStyleBackColor = true;
            this.button_cv.Click += new System.EventHandler(this.button_cv_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Copyright 2019 Villaruz, Villaruz Co., CPAs. All Rights Reserved.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 251);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "VVC Report Generator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ComboBox report_clients;
        public System.Windows.Forms.Button button_jv;
        public System.Windows.Forms.Button button_cv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button button_exit;
    }
}