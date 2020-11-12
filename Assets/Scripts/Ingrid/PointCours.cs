using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PointCours : MonoBehaviour
{
   
    public void Notion1()
    {
        SceneManager.LoadScene(12);

    }

    public void Notion2()
    {
        SceneManager.LoadScene(13);

    }

    public void Notion3()
    {
        SceneManager.LoadScene(14);

    }

    
    public void Quit()
    {
        SceneManager.LoadScene(4);

    }
}
