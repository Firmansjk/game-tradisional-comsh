using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public GameObject playerPaddle;

    private bool isDragging = false;
    private Vector3 offset;
    public Rigidbody2D rb;

    public float moveSpeed = 2f;
    public float jumpForce = 10f;
    public int jumpYThreshold = 1;

    // ground checker
    public float radius;
    public Transform groundChecker;
    public LayerMask whatIsGround;

    private void Start()
    {
        rb = playerPaddle.GetComponent<Rigidbody2D>();
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
            Vector3 inputPosition = Input.mousePosition;

            if (Input.touchCount > 0)
            {
                // Use the position of the first touch for mobile devices
                inputPosition = Input.GetTouch(0).position;
            }

            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(inputPosition);

            if (gameObject.name == "Paddle P1")
            {
                HandlePaddleMovement(mousePosition, 0);
            }
            else if (gameObject.name == "Paddle P2")
            {
                HandlePaddleMovement(mousePosition, 1);
            }
        }
    }

    private void HandlePaddleMovement(Vector3 targetPosition, int touchIndex)
    {
        Vector3 newTargetPosition = new Vector3(targetPosition.x + offset.x, transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, newTargetPosition, moveSpeed * Time.deltaTime);

        // Jump
        if (targetPosition.y > jumpYThreshold && isGrounded())
        {
            Jump();
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
