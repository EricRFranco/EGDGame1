using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [Header("Spawning and Bounds Parameters")]
    public Transform playerSpawnPoint;
    public float yThreshold;

    [Space(10)]
    [Header("Movement Values")]
    public float speed;
    public float jumpForce;

    [Space(10)]
    [Header("Feature Activation")]
    public bool canMove;
    public bool canJump;
    public controlCode control;

    private Rigidbody2D _rb;
    private Animator anim;
    private SpriteRenderer sr;
    private bool inAir = false;
    private bool facingRight = true;
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
        transform.position = playerSpawnPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        canMove = control.can_move;
        canJump = control.can_jump;
        anim.SetBool("Purchased", control.bought_player);
        CheckMovement();

        if(transform.position.y < yThreshold) // Or enemy collision
        {
            Respawn();
        }
    }

    private void CheckMovement()
    {
        anim.SetBool("InAir", false);
        if (canMove)
        {
            float horizontal = Input.GetAxisRaw("Horizontal");
            // Flip character sprite around
            if((horizontal < 0f && facingRight) || (horizontal > 0f && !facingRight))
            {
                transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
                facingRight = !facingRight;
            }

            float speedFactor = (!inAir) ? speed : speed / 2f;
            _rb.velocity = new Vector2(horizontal * speedFactor, _rb.velocity.y);
        }

        anim.SetFloat("Velocity", Mathf.Abs(_rb.velocity.x));

        if (canJump && Input.GetKeyDown(KeyCode.Space) && !inAir)
        {
            _rb.AddForce(new Vector2(0f, jumpForce));
            anim.SetBool("InAir", true);
        }
        
        
    }

    private void Respawn()
    {
        // Return player back to original position
        SceneManager.LoadScene(0);

        // There are other things at some point probably
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            inAir = false;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            inAir = true;
    }
   
    
}
