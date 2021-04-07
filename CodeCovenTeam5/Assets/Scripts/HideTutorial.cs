using UnityEngine;
using System.Collections;

public class HideTutorial : MonoBehaviour
{
    private Canvas CanvasObject; // Assign in inspector

    void Start()
    {
        CanvasObject = GetComponent<Canvas>();
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.K))
        {
            CanvasObject.enabled = !CanvasObject.enabled;
        }
    }
}