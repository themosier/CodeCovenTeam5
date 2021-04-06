using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeScreenshot : MonoBehaviour
{
    public int width;
    public int height;

    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = gameObject.GetComponent<Camera>();
        cam.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space");
            ScreenshotHandler.Screenshot_static(width, height);
            
        }
    }
}
