using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void Connexion ()
    {
        SceneManager.LoadScene(2);

    }

    public void Inscription()
    {
        SceneManager.LoadScene(3);

    }
}
