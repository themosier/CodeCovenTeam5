using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenshotHandler : MonoBehaviour
{
    private static ScreenshotHandler instance;
    private Camera cam;
    private bool takeSS = false;

    // THIS IS REALLY MESSY BUT I'LL FIX IT
    private void Awake()
    {
        instance = this;
        cam = gameObject.GetComponent<Camera>();
    }

    private void OnPostRender()
    {
        if (takeSS)
        {
            takeSS = false;
            RenderTexture rt = cam.targetTexture;
            Texture2D image = new Texture2D(rt.width, rt.height, TextureFormat.ARGB32, false);
            Rect rect = new Rect(0, 0, rt.width, rt.height);
            image.ReadPixels(rect, 0, 0);

            byte[] byteArr = image.EncodeToPNG();
            System.IO.File.WriteAllBytes("Assets/GamePhotos/testImage.png", byteArr);
            Debug.Log("Took picture");

            RenderTexture.ReleaseTemporary(rt);
            cam.targetTexture = null;
            
        }
    }
    private void Screenshot(int width, int height)
    {
        cam.targetTexture = RenderTexture.GetTemporary(width, height, 16);
        takeSS = true;

    }

    public static void Screenshot_static(int width, int height)
    {
        instance.Screenshot(width, height);
    }
}
