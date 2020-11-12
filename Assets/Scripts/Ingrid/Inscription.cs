using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Inscription : MonoBehaviour
{
    public InputField pseudoField;
    public InputField emailField;
    public InputField passwordField;

    public Button submitButton;

    /*public void CallInscription()
    {
        StartCoroutine(Register());

    }

    IEnumerator Register()
    {

        WWWForm form = new WWWForm();
        form.AddField("pseudo", pseudoField.text);
        form.AddField("email", emailField.text);
        form.AddField("password", passwordField.text);
        WWW www = new WWW("http://localhost/Psiga/inscription.php", form);
        yield return www;
        if (www.text == "0")
        {
            Debug.Log("User created successfully.");
            UnityEngine.SceneManagement.SceneManager.LoadScene(4);
        }
        else
        {
            Debug.Log("user creation failed. Error n" + www.text);

        }
    }

    public void VerifyInputs()
    {
        submitButton.interactable = (pseudoField.text.Length >= 3 && emailField.text.Length >= 8 && passwordField.text.Length >= 8);
    }*/

        public void inscription()
        {
            SceneManager.LoadScene(4);

        }

        public void Quit()
        {
            SceneManager.LoadScene(1);

        }


    }
