using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Quiz2 : MonoBehaviour
{
    // Start is called before the first frame update
    static int Nr; 
    private Text Txtquestion;
    private Text TxtBoutonHG;
    //private Text TxtBoutonBG;
    private Text TxtBoutonHD;
    //private Text TxtBoutonBD;


    private Text Txtscore;
    public int Score = 0;
    public int totquestion;
    private int nbrequestion=0;

    private GameObject Question0;

    public string Reponse;
    string[] Quizz = new string[3];
    // Start is called before the first frame update
    void Start()
    {// declaration du conetnue du tableau 
       // Txtquestion = GameObject.Find("Question_Info").GetComponent<Text>();
 
        TxtBoutonHG= GameObject.Find("TxtBoutonHG").GetComponent<Text>();
        TxtBoutonHD = GameObject.Find("TxtBoutonHD").GetComponent<Text>();
        
        
        Txtscore = GameObject.Find("txtscore").GetComponent<Text>();
        Nr = 0;

       // Question0 = GameObject.Find("Question0").gameObject;


        Question0.SetActive(false);

        Quizz[0] = "Quel particule est porteuse de charge ?,Electrons,Protons";
        Quizz[1] = "Quel particule est porteuse de charge ?,c,d";
        Quizz[2] = "Quel particule est porteuse de charge ?,mdr,coucou";
          totquestion = Quizz.Length;
          PoseUneQuestion();
    }

    // Update is called once per frame
    void Update()
    {
      //  Txtscore.text = Score+"";
        
    }
   public void PoseUneQuestion()
    {
        if (nbrequestion <= totquestion) {
         
            nbrequestion += 1;
            
            string[] col = Quizz[Nr].Split(',');




            switch (Nr)
            {
                case 0:

                    Question0.SetActive(false);
                    TxtBoutonHG.text = col[1];
                    TxtBoutonHD.text = col[2];
                    Reponse = col[1];


                    break;






            }
            


            
 
            
            
        }
        Nr = Nr + 1;
    }
}
