using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    private Rigidbody2D _rb;
    private bool inAir = false;
    
    // Start is called before the first frame update
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        transform.position = playerSpawnPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        CheckMovement();

        if(transform.position.y < yThreshold) // Or enemy collision
        {
            Respawn();
        }
    }

    private void CheckMovement()
    {
        if (canMove)
        {
            float horizontal = Input.GetAxisRaw("Horizontal");
            float speedFactor = (!inAir) ? speed : speed / 2f;
            _rb.velocity = new Vector2(horizontal * speedFactor, _rb.velocity.y);
        }

        if (canJump && Input.GetKeyDown(KeyCode.Space) && !inAir)
        {
            _rb.AddForce(new Vector2(0f, jumpForce));
        }
    }

    private void Respawn()
    {
        // Return player back to original position
        transform.position = playerSpawnPoint.position;

        // There are other things at some point probably
    }

    private void OnCollisionStay2D(Collision2D collision)
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
