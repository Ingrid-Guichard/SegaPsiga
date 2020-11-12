using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelUnlock : MonoBehaviour
{
    // Start is called before the first frame update
    public Button[] button;

    public void LoadNotion1()
    {
        SceneManager.LoadScene(7);
        Time.timeScale = 1f;
    }
    public void LoadNotion2()
    {
        SceneManager.LoadScene(8);
        Time.timeScale = 1f;
    }

    public void LoadLevel()
    {
        //SceneManager.LoadScene(button);
    }
    // Start is called before the first frame update
    void Awake()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached", 1);
        for (int i = 0; i < button.Length; i++)
        {
            if (i+1 > levelReached )
            {
                button[i].interactable = false;
                
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
