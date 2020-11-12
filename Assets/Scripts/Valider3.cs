using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Valider3 : MonoBehaviour
{
    private GameObject UI;
    private float Intensité;
    private int NbEssaies;
    Animator anim;
    Animator anim2;
    // Start is called before the first frame update
    void Start()
    {
        NbEssaies = 3;
        UI = GameObject.Find("Intensité");


        anim = GameObject.FindGameObjectWithTag("Canvas").GetComponent<Animator>();
        anim2 = GameObject.Find("Explosion").GetComponent<Animator>();
    }

    // Update is called once per frame
   public void OnClick2()
    {
        Intensité = float.Parse(UI.GetComponent<Text>().text);
        if (Intensité == 40 )
        {
            anim.SetTrigger("Win");
        }
        else
        {
            //Debug.Log("Hello");ss
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
