using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScen : MonoBehaviour
{
    private GameManager gm;
    private Inventory inventory;

    public void LoadStartScene()
    {
        SceneManager.LoadScene(7);
        gm.lastCheckPointPos = new Vector2(-4.73f, 0.85f);
    }
    public void LoadNextScene2()
    {
        SceneManager.LoadScene(6);
         PlayerPrefs.SetInt("levelReached", 1);

    }
    public void BackMenu()
    {
        SceneManager.LoadScene(4);
    }
    public void LoadNextScene()
    {
        SceneManager.LoadScene(7);
        gm.lastCheckPointPos = new Vector2(9.38f, 19.83f);

    }
    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameManager>();
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
