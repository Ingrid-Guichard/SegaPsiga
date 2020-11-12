using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField]
    private float speed;
    private Rigidbody2D rb;
    public Transform groundDetection;
    public float distance;
    private bool movingRight = true;

    private Caractère_comportement player;

    void Awake()
    {
        //rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Caractère_comportement>();
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.CompareTag("Balise"))
        {
            Flip();
        }
    }
    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector2.right * speed * Time.deltaTime);
        RaycastHit2D groundInfo = Physics2D.Raycast(groundDetection.position, Vector2.down, 2f);
        if (groundInfo.collider == false)
        {

            Flip();

        }
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

