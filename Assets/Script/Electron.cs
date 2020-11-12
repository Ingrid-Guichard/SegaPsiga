using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Electron : MonoBehaviour
{

    public float speed;
    private Rigidbody2D rb;
    private Vector2 ScreenBounds;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, 0);
        //ScreenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));
    }
    // Update is called once per frame
    void Update()
    {
            /*if (transform.position.x > ScreenBounds.x)
            {
                Destroy(this.gameObject);
            }*/
    }
}
