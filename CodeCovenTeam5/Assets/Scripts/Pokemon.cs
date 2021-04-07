using UnityEngine;
using UnityEngine.UI;


public class Pokemon : MonoBehaviour {

    private RaycastHit Hit;
    void Update ()
    {

        if (!Input.GetMouseButtonDown(0))
        {
            return;
        }
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            // Check if hit.transform is creature, 
            if (hit.transform.gameObject.tag == "Pokemon")
            {
                Score.playerScore ++;
                hit.collider.gameObject.tag="AlreadyHit";
                print("It's a Pokemon!");
            }



        }
    }
    }
