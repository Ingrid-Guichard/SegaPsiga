using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuGame : MonoBehaviour
{
    public Text playerDisplay;

    private void Start()
    {
        if (DBManager.LoggedIn)
        {
            playerDisplay.text = "Joueur: " + DBManager.username;
        }
    }
    public void Jouer()
    {
        SceneManager.LoadScene(6);

    }

    public void Cours()
    {
        SceneManager.LoadScene(5);

    }

    public void Quit()
    {
        SceneManager.LoadScene(1);

    }
}
