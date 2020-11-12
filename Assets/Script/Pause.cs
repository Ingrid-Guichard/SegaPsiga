using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public bool GameisPause=false;
    public GameObject pauseMenuUI;
    public GameObject pauseButtonUI;
    private GameManager gm;
    private Caractère_comportement player;
    private void Start()
    {
        gm= GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameManager>();
         player = GameObject.FindGameObjectWithTag("Player").GetComponent<Caractère_comportement>();
    
    }
    public void PauseGame()
    {
        pauseMenuUI.SetActive(true);
        pauseButtonUI.SetActive(false);
        Time.timeScale = 0f;
        GameisPause = true;
    }
    public void ResumeFct()
    {
        pauseMenuUI.SetActive(false);
        pauseButtonUI.SetActive(true);
        Time.timeScale = 1f;
        GameisPause = false;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1f;
    }

    public void LoadStartScene()
    {
        SceneManager.LoadScene(6);
        Time.timeScale = 1f;
    }
    public void LoadCours()
    {
        SceneManager.LoadScene(5);
        Time.timeScale = 0f;
        gm.lastCheckPointPos = player.transform.position;

    }

}
