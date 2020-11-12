using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{

    public int levelToLoad;
    
    public GameObject Sprite;
    public GameObject Sprite1;
    private Inventory inventory;
    public int levelToUnlock;
    public int numberDoor;
    private void Start()
    
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && inventory.isFull[numberDoor] == true)
        {
            Sprite.SetActive(true);

 
        }
        if (collision.CompareTag("Player") && inventory.isFull[numberDoor] == false)
        {
            Sprite1.SetActive(true);


        }

    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")&& inventory.isFull[numberDoor] == true)
        {
           
            if (Input.GetKeyDown("e") )
            {
                SceneManager.LoadScene(levelToLoad);
               

            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Sprite.SetActive(false);
             Sprite1.SetActive(false);
        }
    }


}
