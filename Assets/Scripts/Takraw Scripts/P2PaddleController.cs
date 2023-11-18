using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2PaddleController : MonoBehaviour
{
    //movement
    private bool isDragging = false;
    private Vector3 offset;
    public float moveSpeed = 2f;
    public float jumpForce = 10f;
    public int jumpYThreshold = 1;

    //groundchecker
    public float radius;
    public Transform groundChecker;
    public LayerMask whatIsGround;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void OnMouseDown()
    {
        // Set the dragging flag to true when the object is clicked
        isDragging = true;

        // Calculate the offset between the object's position and the mouse position
        offset = transform.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    private void OnMouseUp()
    {
        // Set the dragging flag to false when the mouse button is released
        isDragging = false;
    }

    private void Update()
    {
        if (isDragging)
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector3 newPosition = new Vector3(mousePosition.x + offset.x, transform.position.y, transform.position.z);

            transform.position = Vector3.Lerp(transform.position, newPosition, moveSpeed * Time.deltaTime);

            if (mousePosition.y > jumpYThreshold && isGrounded())
            {
                Jump();
            }
        }
    }

    public void Jump()
    {
        // Apply an upward force to make the character jump
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    private bool isGrounded()
    {
        return Physics2D.OverlapCircle(groundChecker.position, radius, whatIsGround);
    }

}
