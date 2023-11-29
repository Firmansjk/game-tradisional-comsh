using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    //sprite
    public SpriteRenderer spriteRenderer;
    public Sprite spriteJalan;
    public Sprite spriteLompat;

    public PaddleJump paddleJumpScript;

    public GameObject playerPaddle;

    public Rigidbody2D rb;

    public float moveSpeed = 5f;
    public float jumpForce = 10f;

    // ground checker
    public float radius;
    public Transform groundChecker;
    public LayerMask whatIsGround;

    private bool moveLeft;
    private bool moveRight;
    private float horizontalMove;
    public void Start()
    {
        rb = playerPaddle.GetComponent<Rigidbody2D>();
        moveLeft = false;
        moveRight = false;
    }

    public void PointerDownLeft()
    {
        moveLeft = true;
    }
    public void PointerUpLeft()
    {
        moveLeft = false;
    }
    public void PointerDownRight()
    {
        moveRight = true;
    }
    public void PointerUpRight()
    {
        moveRight = false;
    }

    private void Update()
    {
        MovePlayer();
        if (paddleJumpScript.isGrounded() == false)
        {
            LompatAnimation();
        }
        else
        {
            JalanAnimation();
        }
    }

    public void MovePlayer()
    {
        if (moveLeft)
        {
            horizontalMove = -moveSpeed;
        }
        else if (moveRight)
        {
            horizontalMove = moveSpeed;
        }
        else
        {
            horizontalMove = 0;
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalMove, rb.velocity.y);
    }

    //peralihan sprite
    public void JalanAnimation()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        this.spriteRenderer.sprite = spriteJalan;
    }
    public void LompatAnimation()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        this.spriteRenderer.sprite = spriteLompat;
    }
}
