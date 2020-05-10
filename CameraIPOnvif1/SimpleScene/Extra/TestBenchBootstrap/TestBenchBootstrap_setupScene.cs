// Copyright(C) David W. Jeske, 2013
// Released to the public domain. Use, modify and relicense at will.

using System;
using OpenTK;
using OpenTK.Graphics.OpenGL;

namespace SimpleScene.Demos
{
	partial class TestBenchBootstrap : OpenTK.GameWindow
	{
		protected bool autoWireframeMode = true;

        protected SSObject skyboxCube;
        protected SSObject skyboxStars;

		protected virtual void setupScene() {

            main3dScene = new SSScene (mainShader, pssmShader, instancingShader, instancingPssmShader, otherShaders);
			main3dScene.renderConfig.frustumCulling = true;
            main3dScene.renderConfig.usePoissonSampling = true;
			//main3dScene.BeforeRenderObject += this.beforeRenderObjectHandler;

            alpha3dScene = new SSScene (mainShader, pssmShader, instancingShader, instancingPssmShader, otherShaders);
            alpha3dScene.renderConfig.frustumCulling = true;
            alpha3dScene.renderConfig.usePoissonSampling = false;
            //alpha3dScene.BeforeRenderObject += this.beforeRenderObjectHandler;

			// 0. Add Lights
			var light = new SSDirectionalLight (LightName.Light0);
			light.Direction = new Vector3(0f, 0f, -1f);
			#if true
			if (OpenTKHelper.areFramebuffersSupported ()) {
                if (main3dScene.renderConfig.pssmShader != null && main3dScene.renderConfig.instancePssmShader != null) {
                //if (false) {
					light.ShadowMap = new SSParallelSplitShadowMap (TextureUnit.Texture7);
				} else {
					light.ShadowMap = new SSSimpleShadowMap (TextureUnit.Texture7);
				}
			}
			if (!light.ShadowMap.IsValid) {
				light.ShadowMap = null;
			}
			#endif
			main3dScene.AddLight(light);
		}

        protected virtual void setupCamera()
        {
            var camera = new SSCameraThirdPerson(null);
            camera.followDistance = 50.0f;
            camera.Name = "camera";
            main3dScene.ActiveCamera = camera;
        }

        //protected virtual void beforeRenderObjectHandler (Object obj, SSRenderConfig renderConfig)
        //{
        //	if (autoWireframeMode) {
        //		if (obj == selectedObject) {
        //			renderConfig.drawWireframeMode = WireframeMode.GLSL_SinglePass;
        //		} else {
        //			renderConfig.drawWireframeMode = WireframeMode.None;
        //		}
        //	}
        //}
    }
}