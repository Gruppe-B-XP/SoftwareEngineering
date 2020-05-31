using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenshotHandler : MonoBehaviour
{

    private Camera myCamera;
    //private static ScreenshotHandler instance;
    private bool takeScreenshot;
    private int x = 0;

    private void Awake()
    {
        //instance = this;
        myCamera = gameObject.GetComponent<Camera>();
    }

    private void Update()
    {
        if (takeScreenshot)
        {
            takeScreenshot = false;
            // make the camera render a rectangle with the pixel of the selected width and height.
            RenderTexture renderTexture = myCamera.targetTexture;
            Texture2D result = new Texture2D(renderTexture.width, renderTexture.height, TextureFormat.ARGB32, false);
            Rect rectangle = new Rect(0, 0, renderTexture.width, renderTexture.height);
            result.ReadPixels(rectangle, 0, 0);

            // save those pixel into a byte array and save it as PNG
            byte[] pixels = result.EncodeToPNG();
            System.IO.File.WriteAllBytes(Application.dataPath + "/Screenshot" + x + ".png", pixels);

            // reset the Camera target and the Rendertexture
            myCamera.targetTexture = null;
            RenderTexture.ReleaseTemporary(renderTexture);
        }
    }

    public void Screenshot (int width, int height)
    {
        myCamera.targetTexture = RenderTexture.GetTemporary(width, height);
        takeScreenshot = true;
    }

    
}
