using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
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
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove)
        {
            float horizontal = Input.GetAxisRaw("Horizontal");
            _rb.velocity = new Vector2(horizontal * speed, _rb.velocity.y);
        }  

        if(canJump && Input.GetKeyDown(KeyCode.Space) && !inAir)
        {
            _rb.AddForce(new Vector2(0f, jumpForce));
        }

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
