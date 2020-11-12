using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverManager : MonoBehaviour
     
{
    
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Valider.Gagner == 1)
        {
            anim.SetTrigger("Win");
            
        }
        if(Valider.Gagner==2 && Valider.essai !=0)
        {
            anim.SetTrigger("GameOver");
            anim.SetTrigger("StartAgain");


        }
        if(Valider.essai== 0) {
            Debug.Log("GameOver");
        }
        
    }
}
