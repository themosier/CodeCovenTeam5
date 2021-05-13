using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ScreenshotHandler : MonoBehaviour
{
    private static ScreenshotHandler instance;
    private static Camera cam;
    private static bool takeSS = false;
    private int picCt = 0;

    // THIS IS REALLY MESSY BUT I'LL FIX IT
    private void Awake()
    {
        instance = this;
        cam = gameObject.GetComponent<Camera>();
        Debug.Log(Application.streamingAssetsPath);

        if (Directory.Exists(Application.streamingAssetsPath + "/GamePhotos"))
        {
            Directory.Delete(Application.streamingAssetsPath + "/GamePhotos", true);
            Directory.CreateDirectory(Application.streamingAssetsPath + "/GamePhotos");
        }
    }

    private void Update()
    {
        if (takeSS)
        {
            takeSS = false;

            RenderTexture currRT = RenderTexture.active;
            RenderTexture.active = cam.targetTexture;

            cam.Render();

            Texture2D image = new Texture2D(cam.targetTexture.width, cam.targetTexture.height);
            image.ReadPixels(new Rect(0, 0, cam.targetTexture.width, cam.targetTexture.height), 0, 0);
            image.Apply();
            RenderTexture.active = currRT;

            byte[] Bytes = image.EncodeToPNG();
            Destroy(image);

            File.WriteAllBytes(Application.streamingAssetsPath + "/GamePhotos/gamePicture_" + picCt++ + ".png", Bytes);
            Debug.Log("Took screenshot");


            cam.enabled = false;
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

    public void GetPhotos()
    {
        DirectoryInfo dir = new DirectoryInfo(Application.streamingAssetsPath + "/GamePhotos");
        FileInfo[] info = dir.GetFiles();
        foreach (FileInfo f in info)
        {
            // Here's where we put code to display the images
        }
    }
}
