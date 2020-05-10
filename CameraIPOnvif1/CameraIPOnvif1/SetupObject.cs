using OpenTK;
using SimpleScene;
using SimpleScene.Demos;
using System;
using System.IO;
using static System.Math;

namespace CameraIPOnvif1
{
    partial class Robot : TestBenchBootstrap
    {
        /// <summary>
        /// Joint1 = L0 = 8; 
        /// Joint2 = L1 = 15.5;
        /// Joint3 = L2 = 11.5;
        /// </summary>
        private const float calib_pos = 10f;
        protected override void setupScene()
        {
            using (StreamReader readtext = new StreamReader("TODO.txt"))
            {
                String t0 = readtext.ReadLine();
                if (t0.Contains("/"))
                    _theta0 = _pi/180 * float.Parse(t0.Split('/')[0]) / float.Parse(t0.Split('/')[1]);
                else _theta0 = _pi/180 * float.Parse(t0);

                string t1 = readtext.ReadLine();
                if (t1.Contains("/"))
                    _theta1 = _pi/180 * float.Parse(t1.Split('/')[0]) / float.Parse(t1.Split('/')[1]);
                else _theta1 = _pi/180 * float.Parse(t1);

                string t2 = readtext.ReadLine();
                if (t2.Contains("/"))
                    _theta2 = _pi/180 * float.Parse(t2.Split('/')[0]) / float.Parse(t2.Split('/')[1]);
                else _theta2 = _pi/180 * float.Parse(t2);
            }
            base.setupScene();
            this.KeyDown += this.keyHandler;
            //Add Wheels and Body
            #region thembanhxe&thanxe
            //them banh truoc trai
            var mesh = SSAssetManager.GetInstance<SSMesh_wfOBJ>("./obj/banhxe_truc.obj");
            _wheel1 = new SSObjectMesh(mesh);
            main3dScene.AddObject(_wheel1);
            _wheel1.renderState.lighted = true;
            _wheel1.EulerDegAngleOrient(20f - 90f, 0.0f);
            _wheel1.Pos = new OpenTK.Vector3(-4f, -14.5f - calib_pos, -33.5f);
            _wheel1.Scale = new Vector3(0.045f, 0.045f, 0.045f);
            _wheel1.Name = "banh truoc trai";

            //them banh sau trai
            _wheel2 = new SSObjectMesh(SSAssetManager.GetInstance<SSMesh_wfOBJ>("./obj/banhxe_truc.obj"));
            main3dScene.AddObject(_wheel2);
            _wheel2.renderState.lighted = true;
            _wheel2.EulerDegAngleOrient(-90.0f + 20f, 0.0f);
            _wheel2.Pos = new OpenTK.Vector3(-4f - 16f, -14.5f - calib_pos, -39f);
            _wheel2.Scale = new Vector3(0.045f, 0.045f, 0.045f);
            _wheel2.Name = "banh sau trai";

            //them banh truoc phai
            _wheel3 = new SSObjectMesh(SSAssetManager.GetInstance<SSMesh_wfOBJ>("./obj/banhxe_truc.obj"));
            main3dScene.AddObject(_wheel3);
            _wheel3.renderState.lighted = true;
            _wheel3.EulerDegAngleOrient(90.0f + 20f, 0.0f);
            _wheel3.Pos = new OpenTK.Vector3(6f, -14.5f - calib_pos, -5.5f);
            _wheel3.Scale = new Vector3(0.045f, 0.045f, 0.045f);
            _wheel3.Name = "banh truoc phai";

            //them banh sau phai
            _wheel4 = new SSObjectMesh(SSAssetManager.GetInstance<SSMesh_wfOBJ>("./obj/banhxe_truc.obj"));
            main3dScene.AddObject(_wheel4);
            _wheel4.renderState.lighted = true;
            _wheel4.EulerDegAngleOrient(90f + 20f, 0.0f);
            _wheel4.Pos = new OpenTK.Vector3(6f - 16f, -14.5f - calib_pos, -11.5f);
            _wheel4.Scale = new Vector3(0.045f, 0.045f, 0.045f);
            _wheel4.Name = "banh sau 2";


            // them than xe
            _body = new SSObjectMesh(SSAssetManager.GetInstance<SSMesh_wfOBJ>("./obj/thanxe.obj"));
            main3dScene.AddObject(_body);
            _body.renderState.lighted = true;
            _body.EulerDegAngleOrient(20f, 90f);
            _body.Pos = new OpenTK.Vector3(0f, 0f - calib_pos, -20f);
            _body.Scale = new Vector3(0.05f, 0.05f, 0.05f);
            _body.Name = "than xe";
            #endregion thembanhxe&thanxe
            //Add Joint 1
            #region themkhau1
            _joint1 = new SSObjectMesh(SSAssetManager.GetInstance<SSMesh_wfOBJ>("./obj/khau1.obj"));
            main3dScene.AddObject(_joint1);
            _joint1.renderState.lighted = true;

            var r1 = Matrix4.CreateRotationX(-_pi / 2);
            var r2 = Matrix4.CreateRotationY(_theta0 * 1.0f);
            _tempmatrix0 = r1 * r2 * rz;
            _joint1.Orient(_tempmatrix0);

            _joint1.Pos = new OpenTK.Vector3(-0f, -0f - calib_pos, -20f);
            _joint1.Scale = new Vector3(0.045f, 0.045f, 0.045f);
            _joint1.Name = "khau 1";
            #endregion themkhau1
            //Add Joint 2
            #region themkhau2
            _joint2 = new SSObjectMesh(SSAssetManager.GetInstance<SSMesh_wfOBJ>("./obj/khau2.obj"));
            main3dScene.AddObject(_joint2);
            _joint2.renderState.lighted = true;

            var r3 = Matrix4.CreateRotationZ(_theta1 * 1.0f);
            _tempmatrix1 = rx * ry * r3;

            var r4 = Matrix4.CreateRotationY(_theta0 * 1.0f);
            _tempmatrix2 = rx * r4 * rz;

            _joint2.Orient(_tempmatrix1 * _tempmatrix2);

            _joint2.Pos = new OpenTK.Vector3(-0f, _l0 - calib_pos, -20f);
            _joint2.Scale = new Vector3(0.045f, 0.045f, 0.045f);
            _joint2.Name = "khau 2";
            #endregion themkhau2
            //Add Joint 3
            #region themkhau3
            _joint3 = new SSObjectMesh(SSAssetManager.GetInstance<SSMesh_wfOBJ>("./obj/khau3.obj"));
            main3dScene.AddObject(_joint3);
            _joint3.renderState.lighted = true;

            var r5 = Matrix4.CreateRotationZ(_theta2 * 1.0f);
            _tempmatrix3 = rx * ry * r5;

            var r6 = Matrix4.CreateRotationZ(_theta1 * 1.0f);
            _tempmatrix4 = rx * ry * r6;

            var r7 = Matrix4.CreateRotationY(_theta0 * 1.0f);
            _tempmatrix5 = rx * r7 * rz;

            _joint3.Orient(_tempmatrix3 * _tempmatrix4 * _tempmatrix5);

            float x_j3 = _l1 * (float)Cos((double)_theta0) * (float)Cos((double)_theta1);
            float z_j3 = _l1 * -(float)Sin((double)_theta0) * (float)Cos((double)_theta1) - 20f;
            float y_j3 = _l1 * (float)Sin((double)_theta1) + _l0;

            _joint3.Pos = new OpenTK.Vector3(x_j3, y_j3 - calib_pos, z_j3);
            _joint3.Scale = new Vector3(0.045f, 0.045f, 0.045f);
            _joint3.Name = "khau 3";
            #endregion themkhau3
            //Add Gripper
            #region themgripper
            _gripper = new SSObjectMesh(SSAssetManager.GetInstance<SSMesh_wfOBJ>("./obj/gripper.obj"));
            main3dScene.AddObject(_gripper);
            _gripper.renderState.lighted = true;
            _gripper.Orient(_tempmatrix3 * _tempmatrix4 * _tempmatrix5);

            float x_gr = _l1 * (float)Cos((double)_theta0) * (float)Cos((double)_theta1)
                      + _l2 * (float)Cos((double)_theta0) * (float)Cos((double)_theta1) * (float)Cos((double)_theta2)
                      - _l2 * (float)Cos((double)_theta0) * (float)Sin((double)_theta1) * (float)Sin((double)_theta2)
                      ;
            float z_gr = -_l1 * (float)Sin((double)_theta0) * (float)Cos((double)_theta1) - 20f
                       - _l2 * (float)Sin((double)_theta0) * (float)Cos((double)_theta1) * (float)Cos((double)_theta2)
                       + _l2 * (float)Sin((double)_theta0) * (float)Sin((double)_theta1) * (float)Sin((double)_theta2)
                       ;
            float y_gr = _l1 * (float)Sin((double)_theta1) + _l0
                       + _l2 * (float)Sin((double)_theta1) * (float)Cos((double)_theta2)
                       + _l2 * (float)Cos((double)_theta1) * (float)Sin((double)_theta2)
                       ;
            _gripper.Pos = new OpenTK.Vector3(x_gr, y_gr - calib_pos, z_gr);
            _gripper.Scale = new Vector3(0.045f, 0.045f, 0.045f);
            _gripper.Name = "gripper";
            #endregion themgripper

        }
    }
}
