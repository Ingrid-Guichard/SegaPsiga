using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectNoeud : MonoBehaviour
{
    // Start is called before the first frame update
    private bool Click;
    public static int NbNd;
    private GameObject UI;
   
   
    
    void Start()
            {
       
        Click = false;
        UI = GameObject.Find("NbNoeuds");
       
    }
    
    void OnMouseDown()
    {
      
        Debug.Log("Hello");
        if (Click == false)
        {
            gameObject.transform.GetChild(0).gameObject.SetActive(true);

            NbNd = int.Parse(UI.GetComponent<Text>().text) - 1;
            UI.GetComponent<Text>().text = NbNd + "";
            Click = true;
            
        }
    }

   
}
