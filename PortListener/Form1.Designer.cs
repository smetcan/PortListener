namespace PortListener
{
    partial class Form1
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
            this.cmoPorts = new System.Windows.Forms.ComboBox();
            this.lblPortDetails = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmoPorts
            // 
            this.cmoPorts.FormattingEnabled = true;
            this.cmoPorts.Location = new System.Drawing.Point(46, 34);
            this.cmoPorts.Name = "cmoPorts";
            this.cmoPorts.Size = new System.Drawing.Size(106, 21);
            this.cmoPorts.TabIndex = 0;
            this.cmoPorts.SelectedIndexChanged += new System.EventHandler(this.cmoPorts_SelectedIndexChanged);
            // 
            // lblPortDetails
            // 
            this.lblPortDetails.AutoSize = true;
            this.lblPortDetails.Location = new System.Drawing.Point(14, 113);
            this.lblPortDetails.Name = "lblPortDetails";
            this.lblPortDetails.Size = new System.Drawing.Size(35, 13);
            this.lblPortDetails.TabIndex = 1;
            this.lblPortDetails.Text = "label1";
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(12, 237);
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(363, 528);
            this.txtLog.TabIndex = 2;
            this.txtLog.Text = "";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(158, 32);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(83, 23);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Bağlan";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(247, 32);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(83, 23);
            this.btnDisconnect.TabIndex = 3;
            this.btnDisconnect.Text = "Bağlantıyı Kes";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(336, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(21, 21);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmoPorts);
            this.groupBox1.Controls.Add(this.btnDisconnect);
            this.groupBox1.Controls.Add(this.lblPortDetails);
            this.groupBox1.Controls.Add(this.btnConnect);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 205);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port Bilgileri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 777);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtLog);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Port Dinleme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmoPorts;
        private System.Windows.Forms.Label lblPortDetails;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

