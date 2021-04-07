using UnityEngine;
 using System.Collections;
 
 public class EnableCamera : MonoBehaviour {
     private Canvas CanvasObject;
     public static bool cameraON; // Assign in inspector
 
     void Start()
     {
         CanvasObject = GetComponent<Canvas> ();
         CanvasObject.enabled = !CanvasObject.enabled;
         cameraON = false;
     }
 
     void Update() 
     {
         if (Input.GetKeyDown(KeyCode.LeftShift)) 
         {
             CanvasObject.enabled = !CanvasObject.enabled;
             cameraON = !cameraON;
             print(cameraON);
         }

     }
 }

