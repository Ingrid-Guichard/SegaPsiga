﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    private GameManager gm;
   
    void Start()
    {        
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            gm.lastCheckPointPos = transform.position;
        }
    }
}
