using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TexteTrous2 : MonoBehaviour
{
    public InputField Mot1Field;
    public InputField Mot2Field;    

    public bool Mot1 = false;
    public bool Mot2 = false;
    private static int Nbessai;

    public Button submitButton;
    Animator anim;
    Animator anim2;
    private void Start()
    {
        Nbessai = 2;
    anim = GameObject.FindGameObjectWithTag("Canvas"). GetComponent<Animator>();
    anim2 = GameObject.Find("Explosion").GetComponent<Animator>();  
    }



    public void VerifyWords2()
    {
        if (Mot1Field.text == "récepteur")
        {
            Mot1 = true;
        }
        else
        {
            Mot1 = false;
        }

        if (Mot2Field.text == "générateur")
        {
            Mot2 = true;
        }
        else
        {
            Mot2 = false;
        }
        if (Mot1 == true && Mot2 == true )
        {
            anim.SetTrigger("Win");
        }
        if(Nbessai==0)
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
        submitButton.interactable = (Mot1Field.text.Length >= 1 && Mot2Field.text.Length >= 1);
    }
}
