using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Networking;
using System.Collections;
using UnityEngine.SceneManagement;


public class Connexion : MonoBehaviour
{
    public InputField pseudoField;
    public InputField passwordField;

    public Button submitButton;


    /*public void CallConnexion()
    {
        StartCoroutine(Login());

    }

    IEnumerator Login()
    {

        WWWForm form = new WWWForm();
        form.AddField("pseudo", pseudoField.text);
        form.AddField("password", passwordField.text);
        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost/Psiga/connexion.php", form))
        {
            yield return www.SendWebRequest();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
            }
        }
    }



    public void VerifyInputs()
    {
        submitButton.interactable = (pseudoField.text.Length >= 3 && passwordField.text.Length >= 8);
    }*/

    public void connexion()
    {
        SceneManager.LoadScene(4);

    }

    public void Quit()
    {
        SceneManager.LoadScene(1);

    }
}
