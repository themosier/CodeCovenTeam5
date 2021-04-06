using UnityEngine;
 using System.Collections;
 
 public class EnableCamera : MonoBehaviour {
     private Canvas CanvasObject; // Assign in inspector
 
     void Start()
     {
         CanvasObject = GetComponent<Canvas> ();
         CanvasObject.enabled = !CanvasObject.enabled;
     }
 
     void Update() 
     {
         if (Input.GetKeyDown(KeyCode.LeftShift)) 
         {
             CanvasObject.enabled = !CanvasObject.enabled;
         }

     }
 }

