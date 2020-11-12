using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Reponses : MonoBehaviour
   {
    Animator anim;
    Animator anim2;


    private void Start()
    {
        anim = GameObject.FindGameObjectWithTag("Canvas").GetComponent<Animator>();
        anim2 = GameObject.Find("Explosion").GetComponent<Animator>();
    }
    // Start is called before the first frame update
    public void Oncliclbutton()
    {
        if (gameObject.transform.GetChild(0).GetComponent<Text>().text == "Générateur")
        {
            Debug.Log("Gagné");
            anim.SetTrigger("Win");
        }
        else
        {
            anim2.SetTrigger("Explode");

            anim.SetTrigger("GameO");
        }
        //GameObject.Find("QuestionControlArea").GetComponent<Quiz2>().PoseUneQuestion();
    }
}
