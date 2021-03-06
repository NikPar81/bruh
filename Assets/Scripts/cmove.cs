using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cmove : MonoBehaviour
{
    public float speed;
    public float jumpForce;
    private float moveInput;
    private bool facingRight = true;
    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    private int extraJumps;
    public int extraJumpsValue;
    public Animator anim;
    private Rigidbody2D rb;

    public int catEnd = 0;
    public void Start()
    {
        PlayerPrefs.SetInt("catEnd", 0);
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }
    private void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        moveInput = Input.GetAxis("Horizontal1");
        rb.velocity = new Vector2(moveInput * speed, rb.velocity.y);


        if (facingRight == false && moveInput > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveInput < 0)
        {
            Flip();
        }
        if((moveInput != 0) &(isGrounded == true))
        {
            anim.Play("CatWalk");
        }
        if (isGrounded == true)
        {
            //anim.Play("CatFly");
        }
        if ((moveInput == 0) & (isGrounded == true))
        {
            anim.Play("CatStay");
        }
    }
    public void Update()
    {
        if (isGrounded == true)
        {
            extraJumps = extraJumpsValue;
        }
        if (Input.GetKey(KeyCode.W) && extraJumps > 0)
        {
            rb.velocity = Vector2.up * jumpForce;
            extraJumps--;
            anim.Play("CatJump");


        }
        else if (Input.GetKey(KeyCode.W) && extraJumps == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
            anim.Play("CatJump");
        }

    }
    void OnTriggerEnter2D(Collider2D catEnd)
    {
        if (catEnd.gameObject.tag == "catEnd")
        {
            PlayerPrefs.SetInt("catEnd", 1);
        }
    }
    void OnCollisionEnter2D(Collision2D enemy)
    {
        if (enemy.gameObject.tag == "enemy")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    public void Upal()
    {
        if (isGrounded == true)
        {
            //anim.Play("CatGrounding");
        }
    }
    void Flip()
    {
        facingRight = !facingRight;
        Vector3 Scaler = transform.localScale;
        Scaler.x *= -1;
        transform.localScale = Scaler;

    }
}
