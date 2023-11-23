using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleJump : MonoBehaviour
{
    public PaddleController paddleControllerScript;

    public void Jump()
    {
        // Apply an upward force to make the character jump
        paddleControllerScript.rb.velocity = new Vector2(paddleControllerScript.rb.velocity.x, paddleControllerScript.jumpForce);
    }
}
