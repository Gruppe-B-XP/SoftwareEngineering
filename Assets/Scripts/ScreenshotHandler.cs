using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ScreenshotHandler : MonoBehaviour
{

    private Camera myCamera;
    private GameObject targetObject;
    private Renderer targetRenderer;

    private void Awake()
    {
        myCamera = gameObject.GetComponent<Camera>();
    }

    public IEnumerator Screenshot(int width, int height)
    {
        // wait for end of frame to take the screenshot
        yield return new WaitForEndOfFrame();
        myCamera = GetComponent<Camera>();
        // render new texture
        RenderTexture renTex = new RenderTexture(width, height, 0, RenderTextureFormat.ARGB32);
        myCamera.targetTexture = renTex;
        myCamera.Render();
        // set the rendering to active
        RenderTexture currentRT = RenderTexture.active;
        RenderTexture.active = myCamera.targetTexture;

        //take the screenshot
        Texture2D screenshot = new Texture2D(width, height, TextureFormat.ARGB32, false);
        screenshot.ReadPixels(new Rect(0, 0, width, height), 0, 0, false);
        screenshot.Apply();

        //set the texture into the inner frame object marked with the tag Screenshot
        targetObject = GameObject.FindGameObjectWithTag("Screenshot");
        targetRenderer = targetObject.GetComponent<Renderer>();
        targetRenderer.material.SetTexture("Texture", screenshot);

        // clear the camera rendering
        myCamera.targetTexture = null;
        RenderTexture.active = currentRT;

    }
}