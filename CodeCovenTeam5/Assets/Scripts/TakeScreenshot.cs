using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeScreenshot : MonoBehaviour
{
    public int width;
    public int height;
    public Canvas overlay;

    private Camera cam;

    private AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        cam = gameObject.GetComponent<Camera>();
        cam.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (overlay.enabled && (Input.GetMouseButtonDown(0)))
        {
            cam.enabled = true;
            Debug.Log("Space");
            ScreenshotHandler.Screenshot_static(width, height);
            source.Play();
            
        }
    }
}
