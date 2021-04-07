using System.Collections;
 using UnityEngine;
 using UnityEngine.UI;
 
 public class EndScoreText : MonoBehaviour
 {
         public Text textbox;
 
         void Start()
         {
                 textbox = GetComponent<Text>();
         }
 
         void Update()
         {
                 textbox.text = "Total Creatures Photographed: " + Score.playerScore;
 
         }
 }