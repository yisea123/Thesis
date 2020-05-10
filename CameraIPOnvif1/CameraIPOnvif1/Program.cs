using System;
using System.Windows.Forms;
using SimpleScene;
using SimpleScene.Demos;
using OpenTK;
using OpenTK.Input;
using static System.Math;
using System.Threading;

namespace CameraIPOnvif1
{
	partial class Robot : TestBenchBootstrap
    {
        protected SSObjectMesh _wheel1, _wheel2, _wheel3, _wheel4, _body;
        protected SSObjectMesh _joint1, _joint2, _joint3, _gripper;
        protected const float _l0 = 8f, _l1 = 15.5f, _l2 = 11.5f;
        protected const float _pi = (float)PI;

        //protected float k = 0f;   
        private Matrix4 _tempmatrix0, _tempmatrix1, _tempmatrix2, _tempmatrix3, _tempmatrix4, _tempmatrix5;
        private Matrix4 _modelView1, _modelView2, _modelView3;
        private Matrix4 rx = Matrix4.CreateRotationX(0.0f);
        private Matrix4 ry = Matrix4.CreateRotationY(0.0f);
        private Matrix4 rz = Matrix4.CreateRotationZ(0.0f);

        public static float _theta0;
        public static float _theta1;
        public static float _theta2;

        public Robot() : base("Security Robot"){}
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// </summary>
        [STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}

        protected override void OnUpdateFrame(FrameEventArgs e)
        {
            base.OnUpdateFrame(e);
            
            main3dScene.BeforeRenderObject += this.BeforeRenderObjectHandler;
            if (Form1._socket.Connected == true)
            {
                _simulate((-Form1.Get_theta0() + 20f) * -(_pi / 180.0f), Form1.Get_theta1() * -(_pi / 180.0f), Form1.Get_theta2() * -(_pi / 180.0f));
            }
            Thread.Sleep(50);
        }

        protected void moveJ1(float theta0)
        {
            var r1 = Matrix4.CreateRotationX(-_pi / 2);
            var r2 = Matrix4.CreateRotationY(theta0);
            _modelView1 = r1 * r2 * rz;
            _joint1.Orient(_modelView1);
        }

        protected void moveJ2(float theta0, float theta1)
        {
            var r1 = Matrix4.CreateRotationZ(theta1);
            _modelView2 = rx * ry * r1;

            var r2 = Matrix4.CreateRotationY(theta0);
            _modelView1 = rx * r2 * rz;

            _joint2.Orient(_modelView2 * _modelView1);
        }

        protected void moveJ3(float theta0, float theta1, float theta2)
        {
            var r1 = Matrix4.CreateRotationZ(theta2);
            _modelView3 = rx * ry * r1;

            var r2 = Matrix4.CreateRotationZ(theta1);
            _modelView2 = rx * ry * r2;

            var r3 = Matrix4.CreateRotationY(theta0);
            _modelView1 = rx * r3 * rz;

            _joint3.Orient(_modelView3 * _modelView2 * _modelView1);
            _gripper.Orient(_modelView3 * _modelView2 * _modelView1);

            _joint3.Pos = new OpenTK.Vector3(Form1.Get_xj3(), Form1.Get_yj3() - calib_pos, Form1.Get_zj3());
            _gripper.Pos = new OpenTK.Vector3(Form1.Get_xgr(), Form1.Get_ygr() - calib_pos, Form1.Get_zgr());
        }

        protected virtual void keyHandler(object sender, KeyboardKeyEventArgs e)
        {
            if(Form1.Get_isptz() == true)
            { 
                if (e.Key == Key.Left) Form1.Move("Right");
                else if (e.Key == Key.Right) Form1.Move("Left");
                else if (e.Key == Key.Up) Form1.Move("Down");
                else if (e.Key == Key.Down) Form1.Move("Up");
            }
        }

        private void _simulate(float theta0, float theta1, float theta2)
        {
                    moveJ1(theta0);
                    Thread.Sleep(10);
                    moveJ2(theta0, theta1);
                    Thread.Sleep(10);
                    moveJ3(theta0, theta1, theta2);
                    Thread.Sleep(10);          
        }

        protected virtual void BeforeRenderObjectHandler(Object obj, SSRenderConfig renderConfig)
        {
            if (Form1.Get_element() == "WH")
            {
                if (obj == _wheel1 || obj == _wheel2 || obj == _wheel3 || obj == _wheel4)
                {
                    renderConfig.drawWireframeMode = WireframeMode.GL_Lines;
                    return;
                }
            }
            else
            {
                if (obj == _wheel1)
                {
                    renderConfig.drawWireframeMode = WireframeMode.None;
                }
            }
            if (Form1.Get_element() == "J1")
            {
                if (obj == _joint1)
                {
                    renderConfig.drawWireframeMode = WireframeMode.GL_Lines;
                    return;
                }
            }
            else
            {
                if (obj == _joint1)
                {
                    renderConfig.drawWireframeMode = WireframeMode.None;
                }
            }
            if (Form1.Get_element() == "J2")
            {
                if (obj == _joint2)
                {
                    renderConfig.drawWireframeMode = WireframeMode.GL_Lines;
                    return;
                }
            }
            else
            {
                if (obj == _joint2)
                {
                    renderConfig.drawWireframeMode = WireframeMode.None;
                }
            }
            if (Form1.Get_element() == "J3")
            {
                if (obj == _joint3)
                {
                    renderConfig.drawWireframeMode = WireframeMode.GL_Lines;
                    return;
                }
            }
            else
            {
                if (obj == _joint3)
                {
                    renderConfig.drawWireframeMode = WireframeMode.None;
                }
            }
            if (Form1.Get_element() == "GR")
            {
                if (obj == _gripper)
                {
                    renderConfig.drawWireframeMode = WireframeMode.GL_Lines;
                    return;
                }
            }
            else
            {
                if (obj == _gripper)
                {
                    renderConfig.drawWireframeMode = WireframeMode.None;
                }
            }
        }
    }
}
