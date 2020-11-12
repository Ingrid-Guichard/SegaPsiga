using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{


    [SerializeField]
    private float speed;
    private Rigidbody2D rb;
    
    public float distance;
    private bool movingRight = true;
    private Caractère_comportement player;
    
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Caractère_comportement>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player"))
        {
            player.Damage(1);
            StartCoroutine(player.Knowback(0.4f, 30, player.rb));
            Flip();
        }
        if (col.CompareTag("Balise"))
        {
            Flip();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
        transform.Translate(Vector2.right * speed * Time.deltaTime);
       
        
    }
   
   public void Flip()
    {
        if (movingRight == true)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
            movingRight = false;
            
        }
        else
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
            movingRight = true;
        }
    }
    
}
