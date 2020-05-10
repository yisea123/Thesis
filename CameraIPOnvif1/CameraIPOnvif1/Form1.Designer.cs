namespace CameraIPOnvif1
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Camera = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_joint3 = new System.Windows.Forms.Label();
            this.lb_joint2 = new System.Windows.Forms.Label();
            this.lb_joint1 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txbProcess = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Speed_State = new System.Windows.Forms.Label();
            this.Mode_State = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.PTZ_State = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this._Status = new System.Windows.Forms.GroupBox();
            this.TCP_State = new System.Windows.Forms.Label();
            this.Camera_State = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TCP_ = new System.Windows.Forms.Label();
            this.UART = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.Port_State = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.IP_State = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label53 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.vel_l = new System.Windows.Forms.Label();
            this.lb_vel_robot = new System.Windows.Forms.Label();
            this.vel_r = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.txb_DataUART = new System.Windows.Forms.TextBox();
            this.Start_UART = new System.Windows.Forms.Button();
            this.cbUART = new System.Windows.Forms.ComboBox();
            this.label46 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.txtMaxSpeed = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.Stop_PID = new System.Windows.Forms.Button();
            this.Start_PID = new System.Windows.Forms.Button();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.btn_Kd_l = new System.Windows.Forms.Button();
            this.btn_Ki_l = new System.Windows.Forms.Button();
            this.btn_Kp_l = new System.Windows.Forms.Button();
            this.txt_Set_l = new System.Windows.Forms.TextBox();
            this.txt_ki_l = new System.Windows.Forms.TextBox();
            this.txt_kp_l = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_kd_l = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.btn_Kd_r = new System.Windows.Forms.Button();
            this.label39 = new System.Windows.Forms.Label();
            this.btn_Ki_r = new System.Windows.Forms.Button();
            this.txt_Set_r = new System.Windows.Forms.TextBox();
            this.btn_Kp_r = new System.Windows.Forms.Button();
            this.label40 = new System.Windows.Forms.Label();
            this.txt_kd_r = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.txt_ki_r = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.txt_kp_r = new System.Windows.Forms.TextBox();
            this.label43 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSetUart = new System.Windows.Forms.Button();
            this.labelPort = new System.Windows.Forms.Label();
            this.labelIP = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.txbChatScreen = new System.Windows.Forms.TextBox();
            this.txbSend = new System.Windows.Forms.TextBox();
            this.btnDisconnectTCP = new System.Windows.Forms.Button();
            this.btnConnectTCP = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.Worker2 = new System.ComponentModel.BackgroundWorker();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Worker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.Camera.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this._Status.SuspendLayout();
            this.UART.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.groupBox15.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox13.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Camera);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(54, 21);
            this.tabControl1.Location = new System.Drawing.Point(7, 3);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1351, 692);
            this.tabControl1.TabIndex = 29;
            this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tabControl1_KeyDown);
            // 
            // Camera
            // 
            this.Camera.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Camera.Controls.Add(this.groupBox3);
            this.Camera.Controls.Add(this.groupBox5);
            this.Camera.Controls.Add(this.groupBox9);
            this.Camera.Controls.Add(this.groupBox7);
            this.Camera.Controls.Add(this._Status);
            this.Camera.Controls.Add(this.UART);
            this.Camera.Controls.Add(this.groupBox10);
            this.Camera.Controls.Add(this.groupBox4);
            this.Camera.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Camera.Location = new System.Drawing.Point(4, 25);
            this.Camera.Name = "Camera";
            this.Camera.Padding = new System.Windows.Forms.Padding(3);
            this.Camera.Size = new System.Drawing.Size(1343, 663);
            this.Camera.TabIndex = 0;
            this.Camera.Text = "Control";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_joint3);
            this.groupBox3.Controls.Add(this.lb_joint2);
            this.groupBox3.Controls.Add(this.lb_joint1);
            this.groupBox3.Controls.Add(this.label26);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(174, 533);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(169, 124);
            this.groupBox3.TabIndex = 54;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Robot Arm";
            // 
            // lb_joint3
            // 
            this.lb_joint3.AutoSize = true;
            this.lb_joint3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_joint3.ForeColor = System.Drawing.Color.Blue;
            this.lb_joint3.Location = new System.Drawing.Point(74, 74);
            this.lb_joint3.Name = "lb_joint3";
            this.lb_joint3.Size = new System.Drawing.Size(24, 15);
            this.lb_joint3.TabIndex = 36;
            this.lb_joint3.Text = "0.0";
            // 
            // lb_joint2
            // 
            this.lb_joint2.AutoSize = true;
            this.lb_joint2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_joint2.ForeColor = System.Drawing.Color.Blue;
            this.lb_joint2.Location = new System.Drawing.Point(74, 49);
            this.lb_joint2.Name = "lb_joint2";
            this.lb_joint2.Size = new System.Drawing.Size(24, 15);
            this.lb_joint2.TabIndex = 36;
            this.lb_joint2.Text = "0.0";
            // 
            // lb_joint1
            // 
            this.lb_joint1.AutoSize = true;
            this.lb_joint1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_joint1.ForeColor = System.Drawing.Color.Blue;
            this.lb_joint1.Location = new System.Drawing.Point(74, 26);
            this.lb_joint1.Name = "lb_joint1";
            this.lb_joint1.Size = new System.Drawing.Size(24, 15);
            this.lb_joint1.TabIndex = 36;
            this.lb_joint1.Text = "0.0";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(111, 73);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(52, 15);
            this.label26.TabIndex = 36;
            this.label26.Text = "degrees";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(111, 48);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(52, 15);
            this.label25.TabIndex = 36;
            this.label25.Text = "degrees";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(111, 24);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(52, 15);
            this.label22.TabIndex = 36;
            this.label22.Text = "degrees";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Joint 3 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Joint 2 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Joint 1 :";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txbProcess);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(349, 533);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(375, 124);
            this.groupBox5.TabIndex = 55;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Process";
            // 
            // txbProcess
            // 
            this.txbProcess.Location = new System.Drawing.Point(6, 22);
            this.txbProcess.Multiline = true;
            this.txbProcess.Name = "txbProcess";
            this.txbProcess.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txbProcess.Size = new System.Drawing.Size(355, 81);
            this.txbProcess.TabIndex = 54;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.button1);
            this.groupBox9.Controls.Add(this.Speed_State);
            this.groupBox9.Controls.Add(this.Mode_State);
            this.groupBox9.Controls.Add(this.label33);
            this.groupBox9.Controls.Add(this.label34);
            this.groupBox9.Controls.Add(this.label12);
            this.groupBox9.Controls.Add(this.label31);
            this.groupBox9.Controls.Add(this.label32);
            this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox9.Location = new System.Drawing.Point(730, 533);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(191, 124);
            this.groupBox9.TabIndex = 56;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Control";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 57;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Speed_State
            // 
            this.Speed_State.AllowDrop = true;
            this.Speed_State.AutoSize = true;
            this.Speed_State.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Speed_State.ForeColor = System.Drawing.Color.Blue;
            this.Speed_State.Location = new System.Drawing.Point(77, 49);
            this.Speed_State.Name = "Speed_State";
            this.Speed_State.Size = new System.Drawing.Size(36, 16);
            this.Speed_State.TabIndex = 3;
            this.Speed_State.Text = "High";
            // 
            // Mode_State
            // 
            this.Mode_State.AllowDrop = true;
            this.Mode_State.AutoSize = true;
            this.Mode_State.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mode_State.ForeColor = System.Drawing.Color.Blue;
            this.Mode_State.Location = new System.Drawing.Point(77, 26);
            this.Mode_State.Name = "Mode_State";
            this.Mode_State.Size = new System.Drawing.Size(52, 16);
            this.Mode_State.TabIndex = 3;
            this.Mode_State.Text = "Manual";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(111, 73);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(18, 15);
            this.label33.TabIndex = 1;
            this.label33.Text = "%";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(77, 74);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(28, 15);
            this.label34.TabIndex = 2;
            this.label34.Text = "100";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(8, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 16);
            this.label12.TabIndex = 0;
            this.label12.Text = "Power :";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(8, 49);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(55, 16);
            this.label31.TabIndex = 0;
            this.label31.Text = "Speed :";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(8, 26);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(49, 16);
            this.label32.TabIndex = 0;
            this.label32.Text = "Mode :";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Controls.Add(this.groupBox6);
            this.groupBox7.Controls.Add(this.btnDisconnect);
            this.groupBox7.Controls.Add(this.btnConnect);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.Location = new System.Drawing.Point(3, 107);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(165, 280);
            this.groupBox7.TabIndex = 53;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Camera";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.label24);
            this.groupBox8.Controls.Add(this.label13);
            this.groupBox8.Controls.Add(this.label23);
            this.groupBox8.Controls.Add(this.label14);
            this.groupBox8.Controls.Add(this.PTZ_State);
            this.groupBox8.Controls.Add(this.label21);
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(4, 127);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(156, 100);
            this.groupBox8.TabIndex = 36;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Rear";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(6, 71);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(40, 16);
            this.label24.TabIndex = 35;
            this.label24.Text = "PTZ :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 16);
            this.label13.TabIndex = 35;
            this.label13.Text = "Protocol :";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(6, 46);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(32, 16);
            this.label23.TabIndex = 35;
            this.label23.Text = "fps :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(84, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 15);
            this.label14.TabIndex = 35;
            this.label14.Text = "Onvif";
            // 
            // PTZ_State
            // 
            this.PTZ_State.AutoSize = true;
            this.PTZ_State.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PTZ_State.ForeColor = System.Drawing.Color.Red;
            this.PTZ_State.Location = new System.Drawing.Point(84, 71);
            this.PTZ_State.Name = "PTZ_State";
            this.PTZ_State.Size = new System.Drawing.Size(37, 15);
            this.PTZ_State.TabIndex = 35;
            this.PTZ_State.Text = "False";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(84, 46);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(21, 15);
            this.label21.TabIndex = 35;
            this.label21.Text = "15";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.label18);
            this.groupBox6.Controls.Add(this.label16);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(4, 21);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(156, 100);
            this.groupBox6.TabIndex = 36;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Font";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(6, 70);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 16);
            this.label20.TabIndex = 35;
            this.label20.Text = "PTZ :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(6, 45);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 16);
            this.label18.TabIndex = 35;
            this.label18.Text = "fps :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(6, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 16);
            this.label16.TabIndex = 35;
            this.label16.Text = "Protocol :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Silver;
            this.label19.Location = new System.Drawing.Point(84, 70);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 15);
            this.label19.TabIndex = 35;
            this.label19.Text = "None";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(84, 45);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 15);
            this.label17.TabIndex = 35;
            this.label17.Text = "15";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(84, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 15);
            this.label15.TabIndex = 35;
            this.label15.Text = "Onvif";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.Location = new System.Drawing.Point(84, 233);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDisconnect.Size = new System.Drawing.Size(81, 30);
            this.btnDisconnect.TabIndex = 34;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnConnect.Location = new System.Drawing.Point(0, 233);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(81, 30);
            this.btnConnect.TabIndex = 33;
            this.btnConnect.Text = "Reconnect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnReconnect_Click);
            // 
            // _Status
            // 
            this._Status.Controls.Add(this.TCP_State);
            this._Status.Controls.Add(this.Camera_State);
            this._Status.Controls.Add(this.label2);
            this._Status.Controls.Add(this.TCP_);
            this._Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._Status.Location = new System.Drawing.Point(3, 6);
            this._Status.Name = "_Status";
            this._Status.Size = new System.Drawing.Size(165, 95);
            this._Status.TabIndex = 52;
            this._Status.TabStop = false;
            this._Status.Text = "Status";
            // 
            // TCP_State
            // 
            this.TCP_State.AutoSize = true;
            this.TCP_State.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCP_State.ForeColor = System.Drawing.Color.Red;
            this.TCP_State.Location = new System.Drawing.Point(75, 62);
            this.TCP_State.Name = "TCP_State";
            this.TCP_State.Size = new System.Drawing.Size(82, 15);
            this.TCP_State.TabIndex = 1;
            this.TCP_State.Text = "Disconnected";
            // 
            // Camera_State
            // 
            this.Camera_State.AutoSize = true;
            this.Camera_State.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Camera_State.ForeColor = System.Drawing.Color.Red;
            this.Camera_State.Location = new System.Drawing.Point(76, 31);
            this.Camera_State.Name = "Camera_State";
            this.Camera_State.Size = new System.Drawing.Size(82, 15);
            this.Camera_State.TabIndex = 1;
            this.Camera_State.Text = "Disconnected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Camera :";
            // 
            // TCP_
            // 
            this.TCP_.AutoSize = true;
            this.TCP_.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCP_.Location = new System.Drawing.Point(8, 62);
            this.TCP_.Name = "TCP_";
            this.TCP_.Size = new System.Drawing.Size(57, 16);
            this.TCP_.TabIndex = 0;
            this.TCP_.Text = "TCP/IP :";
            // 
            // UART
            // 
            this.UART.Controls.Add(this.button7);
            this.UART.Controls.Add(this.button8);
            this.UART.Controls.Add(this.label30);
            this.UART.Controls.Add(this.Port_State);
            this.UART.Controls.Add(this.label29);
            this.UART.Controls.Add(this.IP_State);
            this.UART.Controls.Add(this.label28);
            this.UART.Controls.Add(this.label27);
            this.UART.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UART.Location = new System.Drawing.Point(3, 393);
            this.UART.Name = "UART";
            this.UART.Size = new System.Drawing.Size(165, 136);
            this.UART.TabIndex = 0;
            this.UART.TabStop = false;
            this.UART.Text = "TCP/IP";
            // 
            // button7
            // 
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(84, 95);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(81, 27);
            this.button7.TabIndex = 39;
            this.button7.Text = "Setting";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.btnSetUart_Click);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(0, 95);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(81, 27);
            this.button8.TabIndex = 38;
            this.button8.Text = "Connect";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.btnConnectTCP_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(7, 73);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(38, 16);
            this.label30.TabIndex = 35;
            this.label30.Text = "Port :";
            // 
            // Port_State
            // 
            this.Port_State.AutoSize = true;
            this.Port_State.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Port_State.Location = new System.Drawing.Point(85, 73);
            this.Port_State.Name = "Port_State";
            this.Port_State.Size = new System.Drawing.Size(21, 15);
            this.Port_State.TabIndex = 35;
            this.Port_State.Text = "23";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(7, 23);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(64, 16);
            this.label29.TabIndex = 35;
            this.label29.Text = "Protocol :";
            // 
            // IP_State
            // 
            this.IP_State.AutoSize = true;
            this.IP_State.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IP_State.Location = new System.Drawing.Point(85, 48);
            this.IP_State.Name = "IP_State";
            this.IP_State.Size = new System.Drawing.Size(72, 15);
            this.IP_State.TabIndex = 35;
            this.IP_State.Text = "192.168.1.7";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(7, 48);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(26, 16);
            this.label28.TabIndex = 35;
            this.label28.Text = "IP :";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(85, 23);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(30, 15);
            this.label27.TabIndex = 35;
            this.label27.Text = "TCP";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label53);
            this.groupBox10.Controls.Add(this.label11);
            this.groupBox10.Controls.Add(this.label1);
            this.groupBox10.Controls.Add(this.label50);
            this.groupBox10.Controls.Add(this.label8);
            this.groupBox10.Controls.Add(this.label9);
            this.groupBox10.Controls.Add(this.vel_l);
            this.groupBox10.Controls.Add(this.lb_vel_robot);
            this.groupBox10.Controls.Add(this.vel_r);
            this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox10.Location = new System.Drawing.Point(3, 533);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(165, 124);
            this.groupBox10.TabIndex = 0;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Velocity";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label53.Location = new System.Drawing.Point(112, 74);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(27, 15);
            this.label53.TabIndex = 0;
            this.label53.Text = "m/s";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(112, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 15);
            this.label11.TabIndex = 0;
            this.label11.Text = "m/s";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "m/s";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(10, 74);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(51, 16);
            this.label50.TabIndex = 0;
            this.label50.Text = "Robot :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Right :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Left :";
            // 
            // vel_l
            // 
            this.vel_l.AutoSize = true;
            this.vel_l.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vel_l.ForeColor = System.Drawing.Color.Blue;
            this.vel_l.Location = new System.Drawing.Point(74, 26);
            this.vel_l.Name = "vel_l";
            this.vel_l.Size = new System.Drawing.Size(24, 15);
            this.vel_l.TabIndex = 35;
            this.vel_l.Text = "0.0";
            // 
            // lb_vel_robot
            // 
            this.lb_vel_robot.AutoSize = true;
            this.lb_vel_robot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_vel_robot.ForeColor = System.Drawing.Color.Blue;
            this.lb_vel_robot.Location = new System.Drawing.Point(74, 74);
            this.lb_vel_robot.Name = "lb_vel_robot";
            this.lb_vel_robot.Size = new System.Drawing.Size(24, 15);
            this.lb_vel_robot.TabIndex = 35;
            this.lb_vel_robot.Text = "0.0";
            // 
            // vel_r
            // 
            this.vel_r.AutoSize = true;
            this.vel_r.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vel_r.ForeColor = System.Drawing.Color.Blue;
            this.vel_r.Location = new System.Drawing.Point(74, 49);
            this.vel_r.Name = "vel_r";
            this.vel_r.Size = new System.Drawing.Size(24, 15);
            this.vel_r.TabIndex = 35;
            this.vel_r.Text = "0.0";
            // 
            // groupBox4
            // 
            this.groupBox4.AutoSize = true;
            this.groupBox4.Controls.Add(this.pictureBox2);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(169, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1180, 526);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Camera Rear";
            // 
            // pictureBox2
            // 
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(11, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(730, 484);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(753, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 364);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Camera Font";
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(6, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(408, 322);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Menu;
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Controls.Add(this.groupBox15);
            this.tabPage2.Controls.Add(this.groupBox14);
            this.tabPage2.Controls.Add(this.groupBox13);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1343, 663);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Setting";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(391, 6);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(949, 651);
            this.tabControl2.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chart1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(941, 622);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Wheel Left";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(6, 11);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Dap ung Left";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series2.Legend = "Legend1";
            series2.Name = "Set Point Left";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Set Point Left Fil";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Series.Add(series3);
            this.chart1.Size = new System.Drawing.Size(929, 569);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.chart2);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(941, 622);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Wheel Right";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(6, 11);
            this.chart2.Name = "chart2";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Dap ung Right";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StepLine;
            series5.Legend = "Legend1";
            series5.Name = "Set point Right";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Set point Right Fil";
            this.chart2.Series.Add(series4);
            this.chart2.Series.Add(series5);
            this.chart2.Series.Add(series6);
            this.chart2.Size = new System.Drawing.Size(929, 569);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.txb_DataUART);
            this.groupBox15.Controls.Add(this.Start_UART);
            this.groupBox15.Controls.Add(this.cbUART);
            this.groupBox15.Controls.Add(this.label46);
            this.groupBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox15.Location = new System.Drawing.Point(161, 524);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(224, 133);
            this.groupBox15.TabIndex = 31;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "UART";
            // 
            // txb_DataUART
            // 
            this.txb_DataUART.Location = new System.Drawing.Point(10, 65);
            this.txb_DataUART.Name = "txb_DataUART";
            this.txb_DataUART.Size = new System.Drawing.Size(207, 22);
            this.txb_DataUART.TabIndex = 1;
            // 
            // Start_UART
            // 
            this.Start_UART.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_UART.Location = new System.Drawing.Point(165, 31);
            this.Start_UART.Name = "Start_UART";
            this.Start_UART.Size = new System.Drawing.Size(53, 31);
            this.Start_UART.TabIndex = 3;
            this.Start_UART.Text = "Start";
            this.Start_UART.UseVisualStyleBackColor = true;
            this.Start_UART.Click += new System.EventHandler(this.Start_UART_Click);
            // 
            // cbUART
            // 
            this.cbUART.FormattingEnabled = true;
            this.cbUART.Location = new System.Drawing.Point(51, 35);
            this.cbUART.Name = "cbUART";
            this.cbUART.Size = new System.Drawing.Size(110, 24);
            this.cbUART.TabIndex = 3;
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(7, 38);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(38, 16);
            this.label46.TabIndex = 2;
            this.label46.Text = "COM";
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.txtMaxSpeed);
            this.groupBox14.Controls.Add(this.OK);
            this.groupBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox14.Location = new System.Drawing.Point(12, 524);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(143, 100);
            this.groupBox14.TabIndex = 31;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Set Max Speed";
            // 
            // txtMaxSpeed
            // 
            this.txtMaxSpeed.Location = new System.Drawing.Point(10, 21);
            this.txtMaxSpeed.Name = "txtMaxSpeed";
            this.txtMaxSpeed.Size = new System.Drawing.Size(66, 22);
            this.txtMaxSpeed.TabIndex = 1;
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(82, 20);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(36, 23);
            this.OK.TabIndex = 2;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.SendMaxSpeed_Click);
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.Stop_PID);
            this.groupBox13.Controls.Add(this.Start_PID);
            this.groupBox13.Controls.Add(this.groupBox11);
            this.groupBox13.Controls.Add(this.groupBox12);
            this.groupBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox13.Location = new System.Drawing.Point(12, 249);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(373, 269);
            this.groupBox13.TabIndex = 30;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Setting PID";
            // 
            // Stop_PID
            // 
            this.Stop_PID.Location = new System.Drawing.Point(189, 208);
            this.Stop_PID.Name = "Stop_PID";
            this.Stop_PID.Size = new System.Drawing.Size(177, 49);
            this.Stop_PID.TabIndex = 30;
            this.Stop_PID.Text = "Stop";
            this.Stop_PID.UseVisualStyleBackColor = true;
            this.Stop_PID.Click += new System.EventHandler(this.Stop_PID_Click);
            // 
            // Start_PID
            // 
            this.Start_PID.Location = new System.Drawing.Point(7, 208);
            this.Start_PID.Name = "Start_PID";
            this.Start_PID.Size = new System.Drawing.Size(181, 49);
            this.Start_PID.TabIndex = 30;
            this.Start_PID.Text = "Start";
            this.Start_PID.UseVisualStyleBackColor = true;
            this.Start_PID.Click += new System.EventHandler(this.Start_PID_Click);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.btn_Kd_l);
            this.groupBox11.Controls.Add(this.btn_Ki_l);
            this.groupBox11.Controls.Add(this.btn_Kp_l);
            this.groupBox11.Controls.Add(this.txt_Set_l);
            this.groupBox11.Controls.Add(this.txt_ki_l);
            this.groupBox11.Controls.Add(this.txt_kp_l);
            this.groupBox11.Controls.Add(this.label10);
            this.groupBox11.Controls.Add(this.txt_kd_l);
            this.groupBox11.Controls.Add(this.label35);
            this.groupBox11.Controls.Add(this.label44);
            this.groupBox11.Controls.Add(this.label36);
            this.groupBox11.Controls.Add(this.label37);
            this.groupBox11.Controls.Add(this.label38);
            this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox11.Location = new System.Drawing.Point(7, 21);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(181, 181);
            this.groupBox11.TabIndex = 29;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Motor Left";
            // 
            // btn_Kd_l
            // 
            this.btn_Kd_l.Location = new System.Drawing.Point(143, 71);
            this.btn_Kd_l.Name = "btn_Kd_l";
            this.btn_Kd_l.Size = new System.Drawing.Size(32, 23);
            this.btn_Kd_l.TabIndex = 2;
            this.btn_Kd_l.Text = "D";
            this.btn_Kd_l.UseVisualStyleBackColor = true;
            this.btn_Kd_l.Click += new System.EventHandler(this.btn_Kd_l_Click);
            // 
            // btn_Ki_l
            // 
            this.btn_Ki_l.Location = new System.Drawing.Point(143, 44);
            this.btn_Ki_l.Name = "btn_Ki_l";
            this.btn_Ki_l.Size = new System.Drawing.Size(32, 23);
            this.btn_Ki_l.TabIndex = 2;
            this.btn_Ki_l.Text = "I";
            this.btn_Ki_l.UseVisualStyleBackColor = true;
            this.btn_Ki_l.Click += new System.EventHandler(this.btn_Ki_l_Click);
            // 
            // btn_Kp_l
            // 
            this.btn_Kp_l.Location = new System.Drawing.Point(143, 18);
            this.btn_Kp_l.Name = "btn_Kp_l";
            this.btn_Kp_l.Size = new System.Drawing.Size(32, 23);
            this.btn_Kp_l.TabIndex = 2;
            this.btn_Kp_l.Text = "P";
            this.btn_Kp_l.UseVisualStyleBackColor = true;
            this.btn_Kp_l.Click += new System.EventHandler(this.btn_Kp_l_Click);
            // 
            // txt_Set_l
            // 
            this.txt_Set_l.Location = new System.Drawing.Point(11, 148);
            this.txt_Set_l.Name = "txt_Set_l";
            this.txt_Set_l.Size = new System.Drawing.Size(100, 22);
            this.txt_Set_l.TabIndex = 1;
            // 
            // txt_ki_l
            // 
            this.txt_ki_l.Location = new System.Drawing.Point(36, 44);
            this.txt_ki_l.Name = "txt_ki_l";
            this.txt_ki_l.Size = new System.Drawing.Size(100, 22);
            this.txt_ki_l.TabIndex = 1;
            // 
            // txt_kp_l
            // 
            this.txt_kp_l.Location = new System.Drawing.Point(36, 18);
            this.txt_kp_l.Name = "txt_kp_l";
            this.txt_kp_l.Size = new System.Drawing.Size(100, 22);
            this.txt_kp_l.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(148, 102);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 15);
            this.label10.TabIndex = 0;
            this.label10.Text = "m/s";
            // 
            // txt_kd_l
            // 
            this.txt_kd_l.Location = new System.Drawing.Point(36, 71);
            this.txt_kd_l.Name = "txt_kd_l";
            this.txt_kd_l.Size = new System.Drawing.Size(100, 22);
            this.txt_kd_l.TabIndex = 1;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(8, 101);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(34, 16);
            this.label35.TabIndex = 0;
            this.label35.Text = "Vel :";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label44.Location = new System.Drawing.Point(8, 129);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(61, 16);
            this.label44.TabIndex = 0;
            this.label44.Text = "Set Point";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(8, 74);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(30, 16);
            this.label36.TabIndex = 0;
            this.label36.Text = "Kd :";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(8, 47);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(25, 16);
            this.label37.TabIndex = 0;
            this.label37.Text = "Ki :";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(8, 21);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(30, 16);
            this.label38.TabIndex = 0;
            this.label38.Text = "Kp :";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.btn_Kd_r);
            this.groupBox12.Controls.Add(this.label39);
            this.groupBox12.Controls.Add(this.btn_Ki_r);
            this.groupBox12.Controls.Add(this.txt_Set_r);
            this.groupBox12.Controls.Add(this.btn_Kp_r);
            this.groupBox12.Controls.Add(this.label40);
            this.groupBox12.Controls.Add(this.txt_kd_r);
            this.groupBox12.Controls.Add(this.label41);
            this.groupBox12.Controls.Add(this.txt_ki_r);
            this.groupBox12.Controls.Add(this.label45);
            this.groupBox12.Controls.Add(this.label42);
            this.groupBox12.Controls.Add(this.txt_kp_r);
            this.groupBox12.Controls.Add(this.label43);
            this.groupBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox12.Location = new System.Drawing.Point(189, 21);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(177, 181);
            this.groupBox12.TabIndex = 29;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Motor Right";
            // 
            // btn_Kd_r
            // 
            this.btn_Kd_r.Location = new System.Drawing.Point(138, 71);
            this.btn_Kd_r.Name = "btn_Kd_r";
            this.btn_Kd_r.Size = new System.Drawing.Size(32, 23);
            this.btn_Kd_r.TabIndex = 2;
            this.btn_Kd_r.Text = "D";
            this.btn_Kd_r.UseVisualStyleBackColor = true;
            this.btn_Kd_r.Click += new System.EventHandler(this.btn_Kd_r_Click);
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(143, 102);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(27, 15);
            this.label39.TabIndex = 0;
            this.label39.Text = "m/s";
            // 
            // btn_Ki_r
            // 
            this.btn_Ki_r.Location = new System.Drawing.Point(138, 44);
            this.btn_Ki_r.Name = "btn_Ki_r";
            this.btn_Ki_r.Size = new System.Drawing.Size(32, 23);
            this.btn_Ki_r.TabIndex = 2;
            this.btn_Ki_r.Text = "I";
            this.btn_Ki_r.UseVisualStyleBackColor = true;
            this.btn_Ki_r.Click += new System.EventHandler(this.btn_Ki_r_Click);
            // 
            // txt_Set_r
            // 
            this.txt_Set_r.Location = new System.Drawing.Point(11, 147);
            this.txt_Set_r.Name = "txt_Set_r";
            this.txt_Set_r.Size = new System.Drawing.Size(100, 22);
            this.txt_Set_r.TabIndex = 1;
            // 
            // btn_Kp_r
            // 
            this.btn_Kp_r.Location = new System.Drawing.Point(138, 18);
            this.btn_Kp_r.Name = "btn_Kp_r";
            this.btn_Kp_r.Size = new System.Drawing.Size(32, 23);
            this.btn_Kp_r.TabIndex = 2;
            this.btn_Kp_r.Text = "P";
            this.btn_Kp_r.UseVisualStyleBackColor = true;
            this.btn_Kp_r.Click += new System.EventHandler(this.btn_Kp_r_Click);
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(8, 101);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(34, 16);
            this.label40.TabIndex = 0;
            this.label40.Text = "Vel :";
            // 
            // txt_kd_r
            // 
            this.txt_kd_r.Location = new System.Drawing.Point(31, 71);
            this.txt_kd_r.Name = "txt_kd_r";
            this.txt_kd_r.Size = new System.Drawing.Size(100, 22);
            this.txt_kd_r.TabIndex = 1;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(8, 74);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(30, 16);
            this.label41.TabIndex = 0;
            this.label41.Text = "Kd :";
            // 
            // txt_ki_r
            // 
            this.txt_ki_r.Location = new System.Drawing.Point(31, 44);
            this.txt_ki_r.Name = "txt_ki_r";
            this.txt_ki_r.Size = new System.Drawing.Size(100, 22);
            this.txt_ki_r.TabIndex = 1;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(8, 129);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(61, 16);
            this.label45.TabIndex = 0;
            this.label45.Text = "Set Point";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label42.Location = new System.Drawing.Point(8, 47);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(25, 16);
            this.label42.TabIndex = 0;
            this.label42.Text = "Ki :";
            // 
            // txt_kp_r
            // 
            this.txt_kp_r.Location = new System.Drawing.Point(31, 18);
            this.txt_kp_r.Name = "txt_kp_r";
            this.txt_kp_r.Size = new System.Drawing.Size(100, 22);
            this.txt_kp_r.TabIndex = 1;
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label43.Location = new System.Drawing.Point(8, 21);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(30, 16);
            this.label43.TabIndex = 0;
            this.label43.Text = "Kp :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSetUart);
            this.groupBox1.Controls.Add(this.labelPort);
            this.groupBox1.Controls.Add(this.labelIP);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.txbChatScreen);
            this.groupBox1.Controls.Add(this.txbSend);
            this.groupBox1.Controls.Add(this.btnDisconnectTCP);
            this.groupBox1.Controls.Add(this.btnConnectTCP);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 237);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TCP/IP";
            // 
            // btnSetUart
            // 
            this.btnSetUart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSetUart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetUart.Location = new System.Drawing.Point(282, 11);
            this.btnSetUart.Name = "btnSetUart";
            this.btnSetUart.Size = new System.Drawing.Size(84, 48);
            this.btnSetUart.TabIndex = 37;
            this.btnSetUart.Text = "Setting";
            this.btnSetUart.UseVisualStyleBackColor = true;
            this.btnSetUart.Click += new System.EventHandler(this.btnSetUart_Click);
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPort.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelPort.Location = new System.Drawing.Point(90, 32);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(20, 16);
            this.labelPort.TabIndex = 36;
            this.labelPort.Text = "xx";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIP.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelIP.Location = new System.Drawing.Point(90, 16);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(65, 16);
            this.labelIP.TabIndex = 36;
            this.labelIP.Text = "xxx.xxx.x.x";
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(283, 173);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(84, 38);
            this.btnSend.TabIndex = 19;
            this.btnSend.Text = "SEND";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // txbChatScreen
            // 
            this.txbChatScreen.Location = new System.Drawing.Point(4, 65);
            this.txbChatScreen.Multiline = true;
            this.txbChatScreen.Name = "txbChatScreen";
            this.txbChatScreen.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txbChatScreen.Size = new System.Drawing.Size(272, 102);
            this.txbChatScreen.TabIndex = 17;
            // 
            // txbSend
            // 
            this.txbSend.Location = new System.Drawing.Point(4, 173);
            this.txbSend.Multiline = true;
            this.txbSend.Name = "txbSend";
            this.txbSend.Size = new System.Drawing.Size(271, 38);
            this.txbSend.TabIndex = 18;
            // 
            // btnDisconnectTCP
            // 
            this.btnDisconnectTCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnectTCP.Location = new System.Drawing.Point(169, 36);
            this.btnDisconnectTCP.Name = "btnDisconnectTCP";
            this.btnDisconnectTCP.Size = new System.Drawing.Size(107, 23);
            this.btnDisconnectTCP.TabIndex = 9;
            this.btnDisconnectTCP.Text = "DISCONNECT";
            this.btnDisconnectTCP.UseVisualStyleBackColor = true;
            this.btnDisconnectTCP.Click += new System.EventHandler(this.btnDisconnectTCP_Click);
            // 
            // btnConnectTCP
            // 
            this.btnConnectTCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnectTCP.Location = new System.Drawing.Point(169, 13);
            this.btnConnectTCP.Name = "btnConnectTCP";
            this.btnConnectTCP.Size = new System.Drawing.Size(107, 23);
            this.btnConnectTCP.TabIndex = 9;
            this.btnConnectTCP.Text = "CONNECT";
            this.btnConnectTCP.UseVisualStyleBackColor = true;
            this.btnConnectTCP.Click += new System.EventHandler(this.btnConnectTCP_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "PORT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "MODULE IP";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(94, 779);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 1;
            // 
            // Worker2
            // 
            this.Worker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Worker2_DoWork);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Worker1
            // 
            this.Worker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Worker1_DoWork);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1370, 699);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.Camera.ResumeLayout(false);
            this.Camera.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this._Status.ResumeLayout(false);
            this._Status.PerformLayout();
            this.UART.ResumeLayout(false);
            this.UART.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox13.ResumeLayout(false);
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
		private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Camera;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSetUart;
        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox txbChatScreen;
        private System.Windows.Forms.TextBox txbSend;
        private System.Windows.Forms.Button btnDisconnectTCP;
        private System.Windows.Forms.Button btnConnectTCP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.ComponentModel.BackgroundWorker Worker2;
        private System.Windows.Forms.GroupBox _Status;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TCP_;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label PTZ_State;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox UART;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label Port_State;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label IP_State;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label Camera_State;
        private System.Windows.Forms.Label TCP_State;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Button btn_Kd_r;
        private System.Windows.Forms.Button btn_Ki_r;
        private System.Windows.Forms.Button btn_Kp_r;
        private System.Windows.Forms.TextBox txt_kd_r;
        private System.Windows.Forms.TextBox txt_ki_r;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox txt_kp_r;
        private System.Windows.Forms.Button btn_Ki_l;
        private System.Windows.Forms.Button btn_Kp_l;
        private System.Windows.Forms.TextBox txt_Set_l;
        private System.Windows.Forms.TextBox txt_ki_l;
        private System.Windows.Forms.TextBox txt_kp_l;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txt_Set_r;
        private System.Windows.Forms.Button btn_Kd_l;
        private System.Windows.Forms.TextBox txt_kd_l;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.Button Stop_PID;
        private System.Windows.Forms.Button Start_PID;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtMaxSpeed;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.Button Start_UART;
        private System.Windows.Forms.ComboBox cbUART;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txb_DataUART;
        private System.ComponentModel.BackgroundWorker Worker1;
        private System.Windows.Forms.Label vel_l;
        private System.Windows.Forms.Label vel_r;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label lb_vel_robot;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lb_joint3;
        private System.Windows.Forms.Label lb_joint2;
        private System.Windows.Forms.Label lb_joint1;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txbProcess;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label Speed_State;
        private System.Windows.Forms.Label Mode_State;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button button1;
    }
}

