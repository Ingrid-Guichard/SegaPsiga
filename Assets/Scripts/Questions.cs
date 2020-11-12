using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Questions : MonoBehaviour
{
    private TextMesh  Txtquestion;

    // Start is called before the first frame update
    void Start()
    {
        Txtquestion = GameObject.Find("Question_Info").GetComponent<TextMesh>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
