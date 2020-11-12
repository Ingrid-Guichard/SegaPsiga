using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{

    private Caractère_comportement player;
    // Start is called before the first frame update
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Caractère_comportement>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            player.Damage(2);
            StartCoroutine(player.Knowback(0.4f, 30, player.rb));
            
        }
    }
}
