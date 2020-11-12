using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Valider2 : MonoBehaviour
{
    private GameObject UI;
    private int NbMaille;
    private int NbEssaies;
    Animator anim;
    Animator anim2;
    // Start is called before the first frame update
    void Start()
    {
        NbEssaies = 3;
        UI = GameObject.Find("Nb_Maille");


        anim = GameObject.FindGameObjectWithTag("Canvas").GetComponent<Animator>();
        anim2 = GameObject.Find("Explosion").GetComponent<Animator>();
    }

    // Update is called once per frame
   public void OnClick2()
    {   
        NbMaille = int.Parse(UI.GetComponent<Text>().text);
        if (NbMaille == 7 && SelectNoeud.NbNd==0)
        {
            anim.SetTrigger("Win");
        }
        else
        {
            //Debug.Log("Hello");
            NbEssaies = NbEssaies - 1;

            Debug.Log(NbEssaies + "");
            
            if (NbEssaies == 0)
            {
                anim2.SetTrigger("Explode");
                anim.SetTrigger("GameO");
            }
             if (NbEssaies != 0)
            {
                anim.SetTrigger("GameOver");
            }
           

        }

        
       
        
    }
}
