using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Valider : MonoBehaviour
{
    public GameObject explosion;
    private GameManager gm;
    private GameObject slot2;
    private GameObject slot4;
    private GameObject slot5;
    private GameObject slot6;
    private GameObject slot7;
    private GameObject slot8;
    private GameObject slot9;

    public static int Gagner;
    public static int essai;
    Animator anim;
    Animator anim2;
    GameObject canvas1;



    public string slot;
    public string atester;
     void Start()
    {
        //gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameManager>();
        canvas1 = GameObject.FindGameObjectWithTag("Canvas");
        


        anim = GameObject.FindGameObjectWithTag("Canvas"). GetComponent<Animator>();
        //canvas1.SetActive(false);
        anim2 = GameObject.Find("Explosion").GetComponent<Animator>();

        slot2 = GameObject.Find("Slot2");
        slot4 = GameObject.Find("Slot4");
        slot5= GameObject.Find("Slot5");
        slot6 = GameObject.Find("Slot6");
        slot7 = GameObject.Find("Slot7");
        slot8 = GameObject.Find("Slot8");
        slot9 = GameObject.Find("Slot9");
        essai = 3;
        
    }

    // Start is called before the first frame update
    public void  Click()
    {
        

       
        if (slot2.transform.GetChild(0).name=="I5" && slot4.transform.GetChild(0).name == "I3" && slot5.transform.GetChild(0).name == "ND1" && slot6.transform.GetChild(0).name == "I2" && slot7.transform.GetChild(0).name == "ND2" && slot8.transform.GetChild(0).name == "I6" && slot9.transform.GetChild(0).name == "I4" )


        {
            Debug.Log("C'est gagner");
            Gagner = 1;
        }
        else
        {
            Debug.Log("C'est perdu");
            Gagner = 2;
            essai = essai - 1;
        }




        //canvas1.SetActive(true);
        if (Gagner == 1)
        {
            anim.SetTrigger("Win");
            PlayerPrefs.SetInt("levelReached", 2);

        }
        if (Gagner == 2 && essai != 0)
        {
            anim.SetTrigger("GameOver");


        }
        if (essai == 0)

        {
            anim2.SetTrigger("Explode");

            anim.SetTrigger("GameO");
            
        }
       
        //canvas1.SetActive(false);

    }

    // Update is called once per frame

}
