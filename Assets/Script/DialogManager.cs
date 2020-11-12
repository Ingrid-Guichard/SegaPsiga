using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogManager : MonoBehaviour
{
    public GameObject continuButton;
    public GameObject clickF;
    public GameObject Rectangle;
    public TextMeshProUGUI textDisplay;
    
    private int index;
    public float typingScript;
    
    public string[] sentences;

    public bool dialogueActive = false;
    public bool dialogueEnded = false;
    public bool outOfRange = true;


    void Start()
    {
        continuButton.SetActive(false);
        textDisplay.text = "";
    }
    public void EnterRangeOfNPC()
    {
        outOfRange = false;
        clickF.SetActive(true);
        if (dialogueActive == true)
        {
            clickF.SetActive(false);
        }
    }
    public void NPCName()
    {
        outOfRange = false;
        Rectangle.gameObject.SetActive(true);
        
        if (Input.GetKeyDown("e"))
        {
            if (!dialogueActive)
            {
                dialogueActive = true;
                StartCoroutine(StartDialogue());
            }
        }
        
    }


    private IEnumerator StartDialogue()
    {
        if (outOfRange == false)
        {
            int dialogueLength = sentences.Length;
            int currentDialogueIndex = 0;

            while (currentDialogueIndex < dialogueLength )
            {

                StartCoroutine(Type());
                
                if (currentDialogueIndex >= dialogueLength)
                    {
                    continuButton.SetActive(false);
                    dialogueEnded = true;
                    }
                }
                yield return 0;
            }
        }
    
    
    public void DropDialogue()
    {
        clickF.SetActive(false);
        Rectangle.gameObject.SetActive(false);
    }

    public void OutOfRange()
    {
        outOfRange = true;
        if (outOfRange == true)
        {
            dialogueActive = false;
            StopAllCoroutines();
            clickF.SetActive(false);
            Rectangle.gameObject.SetActive(false);
        }
    }


    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingScript);
        }
    }

    /*public void NextSentence()
    {
        continuButton.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }
        else
        {
            textDisplay.text = "";
            continuButton.SetActive(false);
        }
    }*/

}
    

