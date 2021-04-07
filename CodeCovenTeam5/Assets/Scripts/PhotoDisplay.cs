using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class PhotoDisplay : MonoBehaviour
{
    public GameObject[] photoSlots;

    // Start is called before the first frame update
    void Awake()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        Debug.Log("Loaded scene: " + scene.name);

        byte[] bytes;
        Texture2D tex;
        Sprite sprite;

        DirectoryInfo dir = new DirectoryInfo("Assets/GamePhotos");
        FileInfo[] info = dir.GetFiles();
        int index = 0;
        foreach (FileInfo f in info)
        {
            // Here's where we put code to display the images
            if (File.Exists("Assets/GamePhotos/gamePicture_" + index + ".png"))
            {
                bytes = File.ReadAllBytes("Assets/GamePhotos/gamePicture_" + index + ".png");
                tex = new Texture2D(1, 1);
                tex.LoadImage(bytes);

                sprite = Sprite.Create(tex, new Rect(0, 0, tex.width, tex.height), new Vector2(0.5f, 0.5f));

                photoSlots[index].GetComponent<SpriteRenderer>().sprite = sprite;
            }
            index++;
            if (index >= photoSlots.Length)
            {
                break;
            }
        }
    }
}
