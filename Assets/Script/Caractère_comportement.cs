using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caractère_comportement : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator anim;
    public Rigidbody2D rb;

    [SerializeField] 
    private float  speed;

    private bool facingRight;

    [SerializeField]
    private Transform[] groundPoints;

    [SerializeField]
    private float groundRadius;

    [SerializeField]
    private LayerMask whatIsGround;

    [SerializeField]
    private float jumpForce;

    private GameManager gm;

    private bool isGround;
    private bool jump;
    public float jumpTime;
    private float jumpTimeCounter;

    private float horizontal;
    public int curHealth;
    public int maxHealth=5;

    private void Start()
    {
        transform.position = gm.lastCheckPointPos;
    }
    void Awake()
    {
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<GameManager>();
        rb = GetComponent<Rigidbody2D>();        
        anim = GetComponent<Animator>();
        curHealth = maxHealth;
    }

    // Update is called once per frame
     void Update()
    {
        isGround = isGrounded();

        if (horizontal > 0){
            transform.eulerAngles = new Vector3(0, 0, 0);
        } else if (horizontal < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }


        if(isGround==true && Input.GetKeyDown(KeyCode.Space)){
            jump = true;
            jumpTimeCounter = jumpTime;
            rb.velocity = Vector2.up * jumpForce;
            anim.SetBool("isJumping", true);
        }
        if (Input.GetKey(KeyCode.Space) && jump == true)
        {
            if (jumpTimeCounter > 0)
            {
                rb.velocity = Vector2.up * jumpForce;
                jumpTimeCounter -= Time.deltaTime;
                anim.SetBool("isJumping", true);
            }
            else
            {
                jump = false;
            }
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            jump = false;
        }
        if (!isGround)
        {
            anim.SetBool("isJumping", false);
        }
    }

    void FixedUpdate()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
        if (horizontal == 0)
        {
            anim.SetBool("isRunning", false);
        }
        else
        {
            anim.SetBool("isRunning", true);
            
        }

        
        
        isGround = isGrounded();
        if (curHealth > maxHealth)
        {
            curHealth = maxHealth;
        }
        if (curHealth <= 0)
        {
            Die();
        }
        
    }
    

    private void resetValue()
    {
        isGround = false;
    }
    

    private bool isGrounded()
    {
        if (rb.velocity.y <= 0)
        {
            foreach(Transform point in groundPoints)
            {
                Collider2D[] colliders = Physics2D.OverlapCircleAll(point.position, groundRadius, whatIsGround);

                for (int i=0; i < colliders.Length; i++)
                {
                    if (colliders[i].gameObject !=gameObject)
                    {
                        return true;
                    }
                }
            }
        }
        return false;

    }
    void Die()
    {
        GameManager.instance.RestartGame();
    }
    public void Damage(int dmg)
    {
        curHealth -= dmg;
        gameObject.GetComponent<Animation>().Play("Hush1");
    }

    public IEnumerator Knowback(float knockDur, float knockbackPwr, Rigidbody2D rigidbody)
    {
        float timer = 0;

        while (knockDur > timer)
        {
            timer += Time.deltaTime;
            rb.AddForce(new Vector3(rigidbody.velocity.x * -knockbackPwr, rigidbody.velocity.y * -knockbackPwr/7, transform.position.z));
            
        }
        yield return 0;
    }

   
    

}
