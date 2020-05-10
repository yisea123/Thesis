using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using OpenTK;
using OpenTK.Input;
using System.Threading;
using Ozeki.Camera;
using Ozeki.Media;
using System.IO.Ports;
using static System.Math;

namespace CameraIPOnvif1
{
	public partial class Form1 : Form
	{
        //Position of axes from -1 to 1
        
        #region camera    
        private static IIPCamera _camera,_camera2;
		private DrawingImageProvider _imageProvider, _imageProvider2;
		private MediaConnector _connector, _connector2;
		private VideoViewerWF _videoViewerWf, _videoViewerWf2;
        
        private bool connect_flag = false;
        private bool stop_flag = false;
        private static bool isPTZ = false;
        #endregion camera

        #region joystick
        private float x_axis_value = 0;
        private float y_axis_value = 0;
        private static bool _simulateflag = false;
        private static string x_dir = "+";
        private static string x_val = "00000";
        private static string y_dir = "+";
        private static string y_val = "00000";
        private static string _mode = "M";
        private static string _speed = "H";
        public static string _element = "WH";
        private static float _theta0 = 999f;
        private static float _theta1;
        private static float _theta2;
        private static float x_j3;
        private static float y_j3;
        private static float z_j3;
        private static float x_gr;
        private static float y_gr;
        private static float z_gr;

        #endregion joystick

        #region TCP/IP
        public StreamReader STR;
		public StreamWriter STW;
        public string receive;
        public string TexttoSend;
        public static Socket _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
		private const string ipCameraFont = "192.168.1.102:8899";
		private const string ipCameraRear = "192.168.1.80:8899";
		private const string usrName = "admin";
		private const string usrPass = "admin";
        private const string ipSocket = "192.168.1.7";
        private const string portSocket = "23";
        #endregion TCP/IP  

        public Form1()
		{
			InitializeComponent();
			labelIP.Text = ipSocket;
			labelPort.Text = portSocket;
			// Create video viewer UI control
			_imageProvider = new DrawingImageProvider();
			_connector = new MediaConnector();
			_videoViewerWf = new VideoViewerWF();
            
			// Create video viewer UI control
			_imageProvider2 = new DrawingImageProvider();
			_connector2 = new MediaConnector();
			_videoViewerWf2 = new VideoViewerWF();
			SetVideoViewer();
            
        }

        private void StartSimulate()
        {
            using (Robot game = new Robot())
            {
                game.Location = new Point(980,435);
                game.WindowBorder = WindowBorder.Hidden;
                game.Run(15.0);     
            }
        }

        private void SetVideoViewer()
		{
			//Camera Font (1)
			pictureBox1.Controls.Add(_videoViewerWf);
			_videoViewerWf.Size = pictureBox1.Size;
			_videoViewerWf.BackColor = Color.Black;
			_videoViewerWf.TabStop = false;
			_videoViewerWf.FlipMode = FlipMode.None;           
            _videoViewerWf.Location = new Point(6, 19);//Modify
			//Camera Rear (2)
			pictureBox2.Controls.Add(_videoViewerWf2);
			_videoViewerWf2.Size = pictureBox2.Size;
			_videoViewerWf2.BackColor = Color.Black;
			_videoViewerWf2.TabStop = false;
            _videoViewerWf2.FlipMode = FlipMode.FlipXY;
			_videoViewerWf2.Location = new Point(6, 19);//Modify
		}

		private void Form1_Load(object sender, EventArgs e)
		{
            //Camera Font (1)
            _camera = new IPCamera(ipCameraFont, usrName, usrPass);
            _connector.Connect(_camera.VideoChannel, _imageProvider);
            _videoViewerWf.SetImageProvider(_imageProvider);
            _videoViewerWf.Start();
            _camera.Start();

            //Camera Rear (2)
            _camera2 = new IPCamera(ipCameraRear, usrName, usrPass);
			_connector2.Connect(_camera2.VideoChannel, _imageProvider2);
			_videoViewerWf2.SetImageProvider(_imageProvider2);
			_videoViewerWf2.Start();
			_camera2.Start();

            ThreadHelperClass.SetText(this, Camera_State, "Connected");
            Camera_State.ForeColor = Color.Blue;

            //Start Simulate
            Thread startSimulate = new Thread(StartSimulate)
            {
                IsBackground = true
            };
            startSimulate.Priority = ThreadPriority.BelowNormal;
            startSimulate.Start();

            //UART
            //string[] ports = SerialPort.GetPortNames();
            //cbUART.Items.AddRange(ports);
            //if(cbUART.Items.Count != 0)
            //    cbUART.SelectedIndex = 0;

            #region drawsomething
            //chart1.Titles.Add("Wheel Left Velocity");
            //chart1.ChartAreas[0].AxisX.Maximum = 10;
            //chart1.ChartAreas[0].AxisX.Minimum = 0;
            //chart1.ChartAreas[0].AxisY.Maximum = 200;
            //chart1.ChartAreas[0].AxisY.Minimum = -200;
            //chart1.ChartAreas[0].AxisY.Title = "m/s";
            //chart1.ChartAreas[0].AxisX.Title = "s";
            //chart1.Series["Output Left"].BorderWidth = 2;
            //chart1.Series["Set Point Left"].BorderWidth = 2;
            //chart1.Series["Set Point Left Fil"].BorderWidth = 2;

            //chart2.Titles.Add("Wheel Right Velocity");
            //chart2.ChartAreas[0].AxisX.Maximum = 10;
            //chart2.ChartAreas[0].AxisX.Minimum = 0;
            //chart2.ChartAreas[0].AxisY.Maximum = 200;
            //chart2.ChartAreas[0].AxisY.Minimum = -200;
            //chart2.ChartAreas[0].AxisY.Title = "m/s";
            //chart2.ChartAreas[0].AxisX.Title = "s";
            //chart2.Series["Output Right"].BorderWidth = 2;
            //chart2.Series["Set point Right"].BorderWidth = 2;
            //chart2.Series["Set point Right Fil"].BorderWidth = 2;
            #endregion drawsomething
        }

        private void btnReconnect_Click(object sender, EventArgs e)
		{
			//Camera Font (1)
			_camera = new IPCamera("192.168.1.102:8899", "admin", "admin");
			_connector.Connect(_camera.VideoChannel, _imageProvider);
			_videoViewerWf.SetImageProvider(_imageProvider);
			_videoViewerWf.Start();
			_camera.Start();
			//Camera Rear (2)
			_camera2 = new IPCamera("192.168.1.80:8899", "admin", "admin");//Modify
			_connector2.Connect(_camera2.VideoChannel, _imageProvider2);
			_videoViewerWf2.SetImageProvider(_imageProvider2);
			_videoViewerWf2.Start();
			_camera2.Start();

            ThreadHelperClass.SetText(this, Camera_State, "Connected");
            Camera_State.ForeColor = Color.Blue;
        }
	
		private void btnDisconnect_Click(object sender, EventArgs e)
		{
			//Disconect Camera Font
			_videoViewerWf.Stop();
			_camera.Disconnect();
			_camera.Dispose();
			//Disconect Camera Rear
			_videoViewerWf2.Stop();
			_camera2.Disconnect();
			_camera2.Dispose();

            ThreadHelperClass.SetText(this, Camera_State, "Disconnected");
            Camera_State.ForeColor = Color.Red;
        }

        #region Move Camera Rear

        private void tabControl1_KeyDown(object sender, KeyEventArgs e)
        {
            if (isPTZ)
            {
                if (e.KeyCode == Keys.Up) Move("Down");
                if (e.KeyCode == Keys.Down) Move("Up");
                if (e.KeyCode == Keys.Left) Move("Right");
                if (e.KeyCode == Keys.Right) Move("Left");
            }
        }


        public static void Move(string direction)
		{
			if (_camera2 == null) return;
            _camera2.CameraMovement.PanSpeed = (float)0.05;//From 0 to 1
			_camera2.CameraMovement.TiltSpeed = (float)0.05;
			switch (direction)
			{
                case "Up":
                    _camera2.CameraMovement.ContinuousMove(MoveDirection.Up);
                    break;
                case "Down":
					_camera2.CameraMovement.ContinuousMove(MoveDirection.Down);
                    break;
				case "Right":
					_camera2.CameraMovement.ContinuousMove(MoveDirection.Right);
					break;
				case "Left":
					_camera2.CameraMovement.ContinuousMove(MoveDirection.Left);
					break;
			}
		}
        #endregion Move Camera Rear

        private void btnConnectTCP_Click(object sender, EventArgs e)
		{
			IPEndPoint IPEnd = new IPEndPoint(IPAddress.Parse(labelIP.Text), int.Parse(labelPort.Text));
            //timer1.Start();
            btnConnectTCP.Enabled = false;
			btnDisconnectTCP.Enabled = true;
			try
			{
                _socket.Connect(IPEnd);
				if (_socket.Connected)
				{
                    ThreadHelperClass.SetText(this, TCP_State, "Connected");
                    TCP_State.ForeColor = Color.Blue;
                    txbChatScreen.AppendText("Connected To Robot" + "\n");
                    txbProcess.AppendText("Connected To Robot" + "\n");
                    NetworkStream ns = new NetworkStream(_socket);
					STR = new StreamReader(ns);
					STW = new StreamWriter(ns);
					STW.AutoFlush = true;                  
                    //Recieve data
                    Worker2.RunWorkerAsync();
                    //Update Joystick
                    Worker1.RunWorkerAsync();
                }
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} 
        }

        private void btnDisconnectTCP_Click(object sender, EventArgs e)
        {
            ThreadHelperClass.SetText(this, TCP_, "Disconnected");
            TCP_.ForeColor = Color.Red;
            _socket.Close();
            txbChatScreen.AppendText("Disconnected" + "\n");
            btnConnectTCP.Enabled = true;
            btnDisconnectTCP.Enabled = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
		{
			if (txbSend.Text != "")
			{
				TexttoSend = txbSend.Text;
				STW.WriteLine(TexttoSend);
			}
			txbSend.Text = "";
		}

		private void btnSetUart_Click(object sender, EventArgs e)
		{
			SettingUART settingUART = new SettingUART();
			settingUART.ShowDialog();
            if (settingUART.textIP != "" && settingUART.textPort != "") {  
			    labelIP.Text = settingUART.textIP;
			    labelPort.Text = settingUART.textPort;
                IP_State.Text = settingUART.textIP;
                Port_State.Text = settingUART.textPort;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Send_Setpoint();
            //string frameconnect = "START SYSTEM............";
            //Sendframe(frameconnect);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_theta0 != 999f)
            {
                using (StreamWriter writetext = new StreamWriter("TODO.txt"))
                {               
                    writetext.WriteLine((-(-_theta0 + 20f)).ToString());
                    writetext.WriteLine((-_theta1).ToString());
                    writetext.WriteLine((-_theta2).ToString());
                }
            }
        }

        private void UpdateState()
		{            
            string frame2send = "S" +" " +_mode +" " +_speed+" " + _element+" " +x_dir +x_val +" " +y_dir +y_val+" " +"E";
            while (true)
            {
                JoystickState state = Joystick.GetState(0);
               
                //Read analog control values and save into declared variables

                //Update digital button values
                //The xinputdotnetpure wrapper returns the text "Pressed" or "Released" for button state
                //The following if statements read this status for the various buttons, and update the declared status variables
                if (state.GetButton(JoystickButton.Button0).ToString().Equals("Pressed"))
                {
                    x_axis_value = state.GetAxis(JoystickAxis.Axis0);
                    y_axis_value = state.GetAxis(JoystickAxis.Axis1);
                    Int32 h = Convert.ToInt32(x_axis_value * 10000);
                    Int32 k = Convert.ToInt32(y_axis_value * 10000);
                    if (h > 800 || h < -800){
                        {
                            if (h > 0){
                                x_dir = "+";
                            }
                            else{
                                x_dir = "-";
                            }
                        }
                        x_val = Math.Abs(h).ToString("D5");
                        
                    }
                    else
                    {
                        x_val = "00000";
                    }

                    if (k > 800 || k < -800){
                        {
                            if (k > 0){
                                y_dir = "+";
                            }
                            else{
                                y_dir = "-";
                            }
                        }
                        y_val = Math.Abs(k).ToString("D5");
                       
                    }
                    else
                    {
                        y_val = "00000";
                    }
                    frame2send = "S" + " " + _mode + " " + _speed + " " + _element + " " + x_dir + x_val + " " + y_dir + y_val + " " + "E";
                    Sendframe(frame2send);
                    _simulateflag = true;
                    stop_flag = false;
                }
                else
                {
                    _simulateflag = false;
                    if (state.GetButton(JoystickButton.Button1).ToString().Equals("Pressed"))
                    {
                        _mode = "H";
                        ThreadHelperClass.SetText(this, Mode_State, "Home");
                        Mode_State.ForeColor = Color.Red;
                    }
                    /////////////////
                    if (state.GetButton(JoystickButton.Button2).ToString().Equals("Pressed"))
                    {
                        _mode = "M";
                        ThreadHelperClass.SetText(this, Mode_State, "Manual");
                        Mode_State.ForeColor = Color.Blue;
                    }
                    /////////////////
                    if (state.GetButton(JoystickButton.Button3).ToString().Equals("Pressed"))
                    {
                        _speed = "H";
                        ThreadHelperClass.SetText(this, Speed_State, "High");
                        Speed_State.ForeColor = Color.Blue;
                    }
                    /////////////////
                    if (state.GetButton(JoystickButton.Button4).ToString().Equals("Pressed"))
                    {
                        _speed = "L";
                        ThreadHelperClass.SetText(this, Speed_State, "Low");
                        Speed_State.ForeColor = Color.Red;
                    }
                    /////////////////
                    if (state.GetButton(JoystickButton.Button5).ToString().Equals("Pressed"))
                    {
                        _element = "WH";
                    }
                    /////////////////
                    if (state.GetButton(JoystickButton.Button6).ToString().Equals("Pressed"))
                    {
                        _element = "J1";
                    }
                    /////////////////
                    if (state.GetButton(JoystickButton.Button7).ToString().Equals("Pressed"))
                    {
                        _element = "J2";
                    }
                    /////////////////
                    if (state.GetButton(JoystickButton.Button8).ToString().Equals("Pressed"))
                    {
                        _element = "J3";
                    }
                    /////////////////
                    if (state.GetButton(JoystickButton.Button9).ToString().Equals("Pressed"))
                    {
                        _element = "GR";
                    }
                    /////////////////
                    if (state.GetButton(JoystickButton.Button10).ToString().Equals("Pressed"))
                    {
                        isPTZ = !isPTZ;
                        if (isPTZ)
                        {
                            ThreadHelperClass.SetText(this, PTZ_State, "True");
                            PTZ_State.ForeColor = Color.Blue;
                        }
                        else
                        {
                            ThreadHelperClass.SetText(this, PTZ_State, "False");
                            PTZ_State.ForeColor = Color.Red;
                        }
                        Thread.Sleep(150);
                    }
                    /////////////////
                    if (stop_flag == false) {
                        frame2send = "S" + " " + _mode + " " + _speed + " " + "WH" + " " + "+" + "00000" + " " + "+" + "00000" + " " + "E";
                        Sendframe(frame2send);
                        Thread.Sleep(1);
                        frame2send = "S" + " " + _mode + " " + _speed + " " + "J1" + " " + "+" + "00000" + " " + "+" + "00000" + " " + "E";
                        Sendframe(frame2send);
                        Thread.Sleep(1);
                        frame2send = "S" + " " + _mode + " " + _speed + " " + "J2" + " " + "+" + "00000" + " " + "+" + "00000" + " " + "E";
                        Sendframe(frame2send);
                        Thread.Sleep(1);
                        frame2send = "S" + " " + _mode + " " + _speed + " " + "J3" + " " + "+" + "00000" + " " + "+" + "00000" + " " + "E";
                        Sendframe(frame2send);
                        stop_flag = true;
                    }                  
                }

				//Put a limit on how frequently this updates
				Thread.Sleep(1);
				//Frame counter for managing repeated on/off toggling of car functions
				//For example, this counter is used for the headlight on/off toggle, to stop it
				//turning on/off continuously when the button is held down.
				//manually reset counter if it gets large
			}
		}

        private void Worker2_DoWork(object sender, DoWorkEventArgs e)
        {
            //double _time = 0;
           // int _i = 1;
            while (_socket.Connected)
            {              
                try
                {
                    receive = STR.ReadLine();               
                    Thread.Sleep(300);
                    if (receive.Substring(0,3) == "vel")//&& connect_flag
                    {
                        //Display(receive);
                        Displayarm(receive);
                        //_time = _time + 0.3;        
                        double _left = (Convert.ToDouble(receive.Substring(3, 5))/10) * (PI * 0.11 / 30);
                        ThreadHelperClass.SetText(this, vel_l, _left.ToString("000.0"));
                        double _right = (Convert.ToDouble(receive.Substring(8, 5))/10) * (PI * 0.11 / 30);
                        ThreadHelperClass.SetText(this, vel_r, _right.ToString("000.0"));
                        ThreadHelperClass.SetText(this, lb_vel_robot, (_left/2 + _right/2).ToString("000.0"));

                        _theta0 = (float)Convert.ToDouble(receive.Substring(23, 6)) / 100;
                        ThreadHelperClass.SetText(this, lb_joint1, _theta0.ToString("000.00"));
                        _theta1 = (float)Convert.ToDouble(receive.Substring(29, 6)) / 100;
                        ThreadHelperClass.SetText(this, lb_joint2, _theta1.ToString("000.00"));
                        _theta2 = (float)Convert.ToDouble(receive.Substring(35, 6)) / 100;
                        ThreadHelperClass.SetText(this, lb_joint3, _theta2.ToString("000.00"));

                        x_j3 = (float)Convert.ToDouble(receive.Substring(41, 6)) / 100;
                        z_j3 = (float)Convert.ToDouble(receive.Substring(47, 6)) / 100;
                        y_j3 = (float)Convert.ToDouble(receive.Substring(53, 6)) / 100;
                        x_gr = (float)Convert.ToDouble(receive.Substring(59, 6)) / 100;
                        z_gr = (float)Convert.ToDouble(receive.Substring(65, 6)) / 100;
                        y_gr = (float)Convert.ToDouble(receive.Substring(71, 6)) / 100;

                        #region drawsomething
                        //double _time3 = (Convert.ToDouble(receive.Substring(33, 7)) / 1000);// - _time2;
                        //double _set_left_fil = Convert.ToDouble(receive.Substring(13, 5)) / 10;
                        //double _set_right_fil = Convert.ToDouble(receive.Substring(18, 5)) / 10;
                        //double _set_left = Convert.ToDouble(receive.Substring(23, 5)) / 10;
                        //double _set_right = Convert.ToDouble(receive.Substring(28, 5)) / 10;
                        //Draw Something
                        //this.chart1.Invoke(new MethodInvoker(delegate ()
                        //{
                        //    if (_time3 > 10 * _i)
                        //    {
                        //        ++_i;
                        //        chart1.ChartAreas[0].AxisX.Maximum = 10 * _i;
                        //        chart2.ChartAreas[0].AxisX.Maximum = 10 * _i;
                        //    }
                        //    //
                        //    chart1.Series["Output Left"].Points.AddXY(_time3, _left);
                        //    chart1.Series["Set Point Left"].Points.AddXY(_time3 - 0.3, _set_left);                 
                        //    chart1.Series["Set Point Left Fil"].Points.AddXY(_time3, _set_left_fil);
                        //    //
                        //    chart2.Series["Output Right"].Points.AddXY(_time3, _right);
                        //    chart2.Series["Set point Right"].Points.AddXY(_time3 - 0.3, _set_right);
                        //    chart2.Series["Set point Right Fil"].Points.AddXY(_time3, _set_right_fil);
                        //}));
                        //}
                        //if((receive.Substring(0, 3) == "arm"))
                        //{
                        #endregion drawsomething
                    }
                }               
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void Send_Setpoint()
        {
            if (_socket.Connected)
            {
                L_sent = (Convert.ToDouble(Math.Abs(L_value)).ToString("000.0"));
                R_sent = (Convert.ToDouble(Math.Abs(R_value)).ToString("000.0"));
                STW.Write("S" + " " + "T" + " " + "H" + " " + "WH" + " " + L_sign + L_sent + " " + R_sign + R_sent + " " + "E");
            }
        }

        private void btn_Kp_l_Click(object sender, EventArgs e)
        {L_sent = (Convert.ToDouble(Math.Abs(L_value))).ToString("000.0");
            R_sent = (Convert.ToDouble(Math.Abs(R_value))).ToString("000.0");

            STW.Write("S" + " " + "T" + " " + "H" + " " + "WH" + " " + L_sign + L_sent + " " + R_sign + R_sent + " " + "E");
            string PID_para = "";
            if (txt_kp_l.Text != "")
            {
                PID_para = "S" + " " + "C" + " " + "P" + "L" + " " + (Convert.ToDouble(txt_kp_l.Text)).ToString("0000.0000000000") + " " + "E";
                STW.Write(PID_para);
            }
        }

        private void btn_Ki_l_Click(object sender, EventArgs e)
        {
            string PID_para = "";
            if (txt_ki_l.Text != "")
            {
                PID_para = "S" + " " + "C" + " " + "I" + "L" + " " + (Convert.ToDouble(txt_ki_l.Text)).ToString("0000.0000000000") + " " + "E";
                STW.Write(PID_para);
            }
        }

        private void btn_Kd_l_Click(object sender, EventArgs e)
        {
            string PID_para = "";
            if (txt_kd_l.Text != "")
            {
                PID_para = "S" + " " + "C" + " " + "D" + "L" + " " + (Convert.ToDouble(txt_kd_l.Text)).ToString("0000.0000000000") + " " + "E";
                STW.Write(PID_para);
            }
        }

        private void btn_Kp_r_Click(object sender, EventArgs e)
        {
            string PID_para = "";
            if (txt_kp_r.Text != "")
            {
                PID_para = "S" + " " + "C" + " " + "P" + "R" + " " + (Convert.ToDouble(txt_kp_r.Text)).ToString("0000.0000000000") + " " + "E";
                STW.Write(PID_para);
            }
        }

        private void btn_Ki_r_Click(object sender, EventArgs e)
        {
            string PID_para = "";
            if (txt_ki_r.Text != "")
            {
                PID_para = "S" + " " + "C" + " " + "I" + "R" + " " + (Convert.ToDouble(txt_ki_r.Text)).ToString("0000.0000000000") + " " + "E";
                STW.Write(PID_para);
            }
        }

        private void btn_Kd_r_Click(object sender, EventArgs e)
        {
            string PID_para = "";
            if (txt_kd_r.Text != "")
            {
                PID_para = "S" + " " + "C" + " " + "D" + "R" + " " + (Convert.ToDouble(txt_kd_r.Text)).ToString("0000.0000000000") + " " + "E";
                STW.Write(PID_para);
            }
        }

        #region
        public double L_value = 0;
        public double R_value = 0;
        public string L_sign = "+";
        public string R_sign = "+";
        public string L_sent = "000.0";
        public string R_sent = "000.0";
        #endregion 

        private void Start_PID_Click(object sender, EventArgs e)
        {
            if (!connect_flag)
            {
                connect_flag = true;
                STW.Write("S" + " " + "T" + " " + "H" + " " + "BE" + " " + "+000.0" + " " + "+000.0" + " " + "E");               
            }
            if (txt_Set_l.Text != "")
            {
                L_value = Convert.ToDouble(txt_Set_l.Text);
            }
            else L_value = 000.0;
            if (txt_Set_r.Text != "")
            {
                R_value = Convert.ToDouble(txt_Set_r.Text);
            }
            else R_value = 000.0;

            if (L_value >= 0)
                L_sign = "+";
            else
                L_sign = "-";

            if (R_value >= 0)
                R_sign = "+";
            else
                R_sign = "-";

            timer1.Start();           
        }

        private void Stop_PID_Click(object sender, EventArgs e)
        {
            connect_flag = false;
            timer1.Stop();
            STW.Write("S" + " " + "T" + " " + "H" + " " + "FI" + " " + "+000.0" + " " + "+000.0" + " " + "E");
        }

        private void Start_UART_Click(object sender, EventArgs e)
        {
            //if (Start_UART.Text == "Start")
            //{
            //    try
            //    {
            //        serialPort1.PortName = cbUART.Text;
            //        serialPort1.Open();
            //        Start_UART.Text = "Close";
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
            //else if (Start_UART.Text == "Close")
            //{
            //    serialPort1.Close();
            //    Start_UART.Text = "Start";
            //}
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //int buf_size = serialPort1.ReadBufferSize;//Read buffer size
            //char[] buff = new char[buf_size];
            //int num_char = serialPort1.Read(buff, 0, buf_size);//Count number of characters in buffer
            //string s = "";
            //for (int index = 0; index < num_char; index++)
            //{
            //    if (buff[index] != 'S' && buff[index] != 'E')
            //        s = s + Convert.ToString(buff[index]);
            //    else if (buff[index] == 'E')
            //        index = num_char;
            //}
            //Display(s);
        }

        private delegate void DisplayCallback2(string s);
        private void Displayarm(string s)
        {
            if (txbProcess.InvokeRequired)
            {
                DisplayCallback2 sd = new DisplayCallback2(Displayarm);
                txbProcess.Invoke(sd, new object[] { s });
            }
            else
                txbProcess.Text = s;
        }

        //private delegate void DisplayCallback(string s);
        //private void Display(string s)
        //{
        //    if (txbChatScreen.InvokeRequired)
        //    {
        //        DisplayCallback sd = new DisplayCallback(Display);
        //        txbChatScreen.Invoke(sd, new object[] { s });
        //    }
        //    else
        //        txbChatScreen.Text = s;
        //}

        private void Worker1_DoWork(object sender, DoWorkEventArgs e)
        {
            UpdateState();
        }

        private void SendMaxSpeed_Click(object sender, EventArgs e)
        {
            if ((Convert.ToDouble(txtMaxSpeed.Text) >= 0 && (Convert.ToDouble(txtMaxSpeed.Text) <= 350)))
            {
                String Llll_sent = (Convert.ToDouble(txtMaxSpeed.Text)).ToString("000.0");
                String Rlll_sent = (Convert.ToDouble(txtMaxSpeed.Text)).ToString("000.0");
                STW.Write("S" + " " + "C" + " " + "M" + "A" + "  " + " " + "+" + Llll_sent + " " + "+" + Rlll_sent + " " + "E");
            }
        }

        #region Getter method
        public static string Get_element()
        {
            return _element;
        }

        public static bool Get_isptz()
        {
            return isPTZ;
        }

        public static bool Get_simulate()
        {
            return _simulateflag;
        }

        public static float Get_theta0()
        {
            return _theta0;
        }

        public static float Get_theta1()
        {
            return _theta1;
        }

        public static float Get_theta2()
        {
            return _theta2;
        }

        public static float Get_xj3()
        {
            return x_j3;
        }

        public static float Get_yj3()
        {
            return y_j3;
        }

        public static float Get_zj3()
        {
            return z_j3;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            isPTZ = true;
        }

        public static float Get_xgr()
        {
            return x_gr;
        }

        public static float Get_ygr()
        {
            return y_gr;
        }

        public static float Get_zgr()
        {
            return z_gr;
        }
        #endregion Getter method

        private void Sendframe(string frame)
        {
            if (_socket.Connected)
            {
                if (frame != "")
                {
                    STW.Write(frame);
                }
            }

        }

    }

    public static class ThreadHelperClass
    {
        delegate void SetTextCallback(Form f, Control ctrl, string text);
        /// <summary>
        /// Set text property of various controls
        /// </summary>
        /// <param name="form">The calling form</param>
        /// <param name="ctrl"></param>
        /// <param name="text"></param>
        public static void SetText(Form form, Control ctrl, string text)
        {
            // InvokeRequired required compares the thread ID of the 
            // calling thread to the thread ID of the creating thread. 
            // If these threads are different, it returns true. 
            if (ctrl.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                form.Invoke(d, new object[] { form, ctrl, text });
            }
            else
            {
                ctrl.Text = text;
            }
        }
    }
}
