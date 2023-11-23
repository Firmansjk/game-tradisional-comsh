using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleJump : MonoBehaviour
{
    public PaddleController paddleControllerScript;
    // ground checker
    public float radius;
    public Transform groundChecker;
    public LayerMask whatIsGround;

    public void Jump()
    {
        // Jump
        if (isGrounded())
        {
            // Apply an upward force to make the character jump
            paddleControllerScript.rb.velocity = new Vector2(paddleControllerScript.rb.velocity.x, paddleControllerScript.jumpForce);
        }
    }
    private bool isGrounded()
    {
        return Physics2D.OverlapCircle(groundChecker.position, radius, whatIsGround);
    }
}
