namespace CameraIPOnvif1
{
	partial class SettingUART
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
			this.txbMuduleport = new System.Windows.Forms.TextBox();
			this.btnOK = new System.Windows.Forms.Button();
			this.txbModuleIP = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.btnclose = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.txbMuduleport);
			this.groupBox1.Controls.Add(this.txbModuleIP);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Location = new System.Drawing.Point(12, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(289, 63);
			this.groupBox1.TabIndex = 28;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "TCP/IP";
			// 
			// txbMuduleport
			// 
			this.txbMuduleport.Location = new System.Drawing.Point(78, 36);
			this.txbMuduleport.Name = "txbMuduleport";
			this.txbMuduleport.Size = new System.Drawing.Size(119, 20);
			this.txbMuduleport.TabIndex = 10;
			// 
			// btnOK
			// 
			this.btnOK.Location = new System.Drawing.Point(185, 81);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(116, 44);
			this.btnOK.TabIndex = 9;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
			// 
			// txbModuleIP
			// 
			this.txbModuleIP.Location = new System.Drawing.Point(78, 13);
			this.txbModuleIP.Name = "txbModuleIP";
			this.txbModuleIP.Size = new System.Drawing.Size(119, 20);
			this.txbModuleIP.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(35, 39);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 13);
			this.label5.TabIndex = 8;
			this.label5.Text = "PORT";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(6, 16);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "MODULE IP";
			// 
			// btnclose
			// 
			this.btnclose.Location = new System.Drawing.Point(12, 81);
			this.btnclose.Name = "btnclose";
			this.btnclose.Size = new System.Drawing.Size(126, 44);
			this.btnclose.TabIndex = 29;
			this.btnclose.Text = "Close";
			this.btnclose.UseVisualStyleBackColor = true;
			this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
			// 
			// SettingUART
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(340, 143);
			this.Controls.Add(this.btnclose);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.groupBox1);
			this.Name = "SettingUART";
			this.Text = "SettingUART";
			this.Load += new System.EventHandler(this.SettingUART_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox txbMuduleport;
		private System.Windows.Forms.Button btnOK;
		private System.Windows.Forms.TextBox txbModuleIP;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnclose;
	}
}