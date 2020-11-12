using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NPG : MonoBehaviour
{
    public GameObject ListenSprite;
    public GameObject continuButton;
    public TextMeshProUGUI textDisplay;
    
    private int index;
    public float typingScript;
    private bool onTarget;
    private DialogManager dialogManager;

    public string[] sentences;


    // Start is called before the first frame update
    void Start()
    {
        dialogManager = FindObjectOfType<DialogManager>();
        ListenSprite.SetActive(false);
    }
    

    private void OnTriggerStay2D(Collider2D collision)
    {
        this.gameObject.GetComponent<NPG>().enabled = true;

        dialogManager.EnterRangeOfNPC();
        if (collision.CompareTag("Player")&& Input.GetKeyDown("e"))
        {
            
            dialogManager.sentences = sentences;
            dialogManager.NPCName();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        dialogManager.OutOfRange();
        this.gameObject.GetComponent<NPG>().enabled = false;
    }
    
     




}
