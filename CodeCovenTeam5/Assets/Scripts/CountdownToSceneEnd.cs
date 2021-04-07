using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CountdownToSceneEnd : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      StartCoroutine (loadSceneAfterDelay(120));  
    }

IEnumerator loadSceneAfterDelay(float waitbySecs){

        yield return new WaitForSeconds(waitbySecs);

         {
   SceneManager.LoadScene(2);
            Debug.Log("Switched to end scene");
 }
}
}
