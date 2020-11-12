using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public Sprite[] HeartSprites;
    
    public GameObject eclair;

    private Caractère_comportement player;
    // Start is called before the first frame update
    private void Start()
    {
        
        
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Caractère_comportement>();
    }
    private void Update()
    {
        //eclair = HeartSprites[player.curHealth];
        eclair.gameObject.GetComponent<SpriteRenderer>().sprite = HeartSprites[player.curHealth];

    }
}
