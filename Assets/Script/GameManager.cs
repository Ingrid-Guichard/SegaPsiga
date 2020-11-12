using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public string nextLevel = "Level02";
    public int levelToUnlock = 2;
    public static GameManager instance;
    public Vector2 lastCheckPointPos;

    private void Awake()
    {
        if (instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    public void WinLevel()
    {
        
    }
    

    public void RestartGame()
    {
        Invoke("LoadGameplay", 0f);
    }
    void LoadGameplay()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name);
    }
}
