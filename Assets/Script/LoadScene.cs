using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class LoadScene : MonoBehaviour
{
    public GameObject loadingScreen;
    public GameObject MenuScreen;
    public GameObject OptionScreen;
    public Slider slider;

    public void LoadLevel (int sceneIndex)
    {
        StartCoroutine(LoadAsynchronously(sceneIndex));
    }

    IEnumerator LoadAsynchronously (int sceneIndex)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        loadingScreen.SetActive ( true);
        while (!operation.isDone)
        {
            float progress = Mathf.Clamp01(operation.progress / 0.9f);
            slider.value = progress;
            yield return null;
        }
    }
    public void menu()
    {
        MenuScreen.SetActive(true);
        OptionScreen.SetActive(false);
    }
    public void option()
    {
        MenuScreen.SetActive(false);
        OptionScreen.SetActive(true);
    }

}



