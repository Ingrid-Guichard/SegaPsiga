using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AppNum2 : MonoBehaviour
{
    public InputField answerField;
    public bool answer = false;
    public Button submitButton;
    private static int Nbessai;
    Animator anim;
    Animator anim2;
    private void Start()
    {
        anim = GameObject.FindGameObjectWithTag("Canvas").GetComponent<Animator>();
        anim2 = GameObject.Find("Explosion").GetComponent<Animator>();
        Nbessai = 2;
    }
    public void VerifyAnswer()
    {
        if (answerField.text == "5")
        {
            answer = true;
        }
        else
        {
            answer = false;
        }

        
        if (answer == true)
        {
            anim.SetTrigger("Win");
        }
        if (Nbessai == 0)
        {
            anim2.SetTrigger("Explode");

            anim.SetTrigger("GameO");
        }
        else
        {
            Nbessai = Nbessai - 1;
            anim.SetTrigger("GameOver");
        }
    }


    public void VerifyInputs()
    {
        submitButton.interactable = (answerField.text.Length >= 1);
    }
}
