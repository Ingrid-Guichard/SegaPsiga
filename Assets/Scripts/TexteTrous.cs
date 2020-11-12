using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TexteTrous : MonoBehaviour
{
    public InputField Mot1Field;
    public InputField Mot2Field;
    public InputField Mot3Field;
    public InputField Mot4Field;
    public InputField Mot5Field;
    public InputField Mot6Field;
    public InputField Mot7Field;
    public InputField Mot8Field;

    public bool Mot1 = false;
    public bool Mot2 = false;
    public bool Mot3 = false;
    public bool Mot4 = false;
    public bool Mot5 = false;
    public bool Mot6 = false;
    public bool Mot7 = false;
    public bool Mot8 = false;

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


    public void VerifyWords()
    {
        if (Mot1Field.text == "positif")
        {
            Mot1 = true;
        }
        else
        {
            Mot1 = false;
        }

        if (Mot2Field.text == "négatif")
        {
            Mot2 = true;
        }
        else
        {
            Mot2 = false;
        }

        if (Mot3Field.text == "sens inverse")
            Mot3 = true;
        else
            Mot3 = false;

        if (Mot4Field.text == "charges")
            Mot4 = true;
        else
            Mot4 = false;

        if (Mot5Field.text == "positif")
            Mot5 = true;
        else
            Mot5 = false;

        if (Mot6Field.text == "négatif")
            Mot6 = true;
        else
            Mot6 = false;

        if (Mot7Field.text == "négatif")
            Mot7 = true;
        else
            Mot7 = false;

        if (Mot8Field.text == "positif")
            Mot8 = true;
        else
            Mot8 = false;

        if (Mot1 == true && Mot2 == true && Mot3 == true && Mot4 == true && Mot5 == true && Mot6 == true && Mot7 == true && Mot8 == true)
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
        submitButton.interactable = (Mot1Field.text.Length >= 1 && Mot2Field.text.Length >= 1 && Mot3Field.text.Length >= 1 && Mot4Field.text.Length >= 1 && Mot5Field.text.Length >= 1 && Mot6Field.text.Length >= 1 && Mot7Field.text.Length >= 1 && Mot8Field.text.Length >= 1); 
    }
}
