using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
    public void GameStart()
    {
        SceneManager.LoadScene("Prologue");
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PhotosNotesScreen();
        }
        else if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void PhotosNotesScreen()
    {
        SceneManager.LoadScene("PhotoAlbum");        
    }
    public void CreditsScreen()
    {
        SceneManager.LoadScene("Credits");
    }
    public void MainMenuScreen()
    {
        SceneManager.LoadScene("Zsade");
    }
}