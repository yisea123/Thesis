﻿// Copyright(C) David W. Jeske, 2013
// Released to the public domain. Use, modify and relicense at will.
using OpenTK;
using OpenTK.Input;

namespace SimpleScene.Demos
{
	partial class TestBenchBootstrap : OpenTK.GameWindow 
	{
		protected SSObject selectedObject = null;

		protected virtual void setupInput()
		{
           // this.MouseDown += mouseDownHandler;
            //this.MouseUp += mouseUpHandler;
            //this.MouseMove += mouseMoveHandler;
            //this.MouseWheel += mouseWheelHandler;
            //this.KeyUp += keyUpHandler;
		}

        //protected virtual void mouseDownHandler(object sender, MouseButtonEventArgs e)
        //{
        //    if (!base.Focused) return;

        //    this.mouseButtonDown = true;

        //    // cast ray for mouse click
        //    var clientRect = new System.Drawing.Size(ClientRectangle.Width, ClientRectangle.Height);
        //    Vector2 mouseLoc = new Vector2(e.X, e.Y);

        //    SSRay ray = OpenTKHelper.MouseToWorldRay(
        //        this.main3dScene.renderConfig.projectionMatrix, this.main3dScene.renderConfig.invCameraViewMatrix, clientRect, mouseLoc);

        //    // Console.WriteLine("mouse ({0},{1}) unproject to ray ({2})",e.X,e.Y,ray);
        //    // scene.addObject(new SSObjectRay(ray));

        //    float nearestMain, nearestAlpha;
        //    SSObject selectedObjMain = main3dScene.Intersect(ref ray, out nearestMain);
        //    SSObject selectedObjAlpha = alpha3dScene.Intersect(ref ray, out nearestAlpha);
        //    selectedObject = nearestMain < nearestAlpha ? selectedObjMain : selectedObjAlpha;

        //    //updateTextDisplay ();
        //}

        //protected virtual void mouseUpHandler(object sender, MouseButtonEventArgs e)
        //{
        //    this.mouseButtonDown = false;
        //}

        //protected virtual void mouseMoveHandler(object sender, MouseMoveEventArgs e)
        //{
        //    if (this.mouseButtonDown)
        //    {

        //        // Console.WriteLine("mouse dragged: {0},{1}",e.XDelta,e.YDelta);
        //        this.main3dScene.ActiveCamera.mouseDeltaOrient(e.XDelta, e.YDelta);
        //        // this.activeModel.MouseDeltaOrient(e.XDelta,e.YDelta);
        //    }
        //}

        //protected virtual void mouseWheelHandler(object sender, MouseWheelEventArgs e)
        //{
        //    if (!base.Focused) return;

        //    // Console.WriteLine("mousewheel {0} {1}",e.Delta,e.DeltaPrecise);
        //    SSCameraThirdPerson ctp = main3dScene.ActiveCamera as SSCameraThirdPerson;
        //    if (ctp != null)
        //    {
        //        var amount = -e.DeltaPrecise;
        //        var kbState = OpenTK.Input.Keyboard.GetState();
        //        if (kbState.IsKeyDown(OpenTK.Input.Key.ShiftLeft))
        //        {
        //            amount *= 10f;
        //        }
        //        ctp.followDistance += amount;
        //    }
        //}

        //protected virtual void keyUpHandler(object sender, KeyboardKeyEventArgs e)
        //{
        //    if (!base.Focused) return;

        //    switch (e.Key)
        //    {
        //        //case Key.Number1:
        //        //    if (autoWireframeMode == true)
        //        //    {
        //        //        autoWireframeMode = false;
        //        //    }
        //        //    else
        //        //    {
        //        //        main3dScene.renderConfig.drawWireframeMode = SSRenderConfig.NextWireFrameMode(main3dScene.renderConfig.drawWireframeMode);
        //        //        if (main3dScene.renderConfig.drawWireframeMode == WireframeMode.None)
        //        //        {
        //        //            autoWireframeMode = true; // rollover completes toggling modes
        //        //        }
        //        //    }
        //        //    break;
        //        case Key.Escape:
        //            Exit();
        //            break;
        //    }
        //}
    }
}

