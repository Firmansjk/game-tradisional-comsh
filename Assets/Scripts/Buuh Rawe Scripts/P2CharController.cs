using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2CharController : MonoBehaviour
{
    private Vector2 touchStartPosition;
    private bool isBeingTouched;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Check if there is any touch input
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0); // Assume only one touch for simplicity

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    // Check if the touch began on this object
                    if (IsTouchingObject(touch.position))
                    {
                        isBeingTouched = true;
                        touchStartPosition = touch.position;
                    }
                    break;

                case TouchPhase.Moved:
                    // Move the object if it is being touched
                    if (isBeingTouched)
                    {
                        Vector2 touchDelta = touch.position - touchStartPosition;

                        // Apply force to the Rigidbody based on touch movement
                        rb.AddForce(touchDelta * Time.deltaTime, ForceMode2D.Impulse);

                        touchStartPosition = touch.position;
                    }
                    break;

                case TouchPhase.Ended:
                    // Reset the touch state
                    isBeingTouched = false;
                    break;
            }
        }
    }

    bool IsTouchingObject(Vector2 touchPosition)
    {
        // Convert the touch position to world coordinates
        Vector2 touchWorldPosition = Camera.main.ScreenToWorldPoint(touchPosition);

        // Check if the touch is within the bounds of this object's collider
        Collider2D collider = GetComponent<Collider2D>();
        return collider.bounds.Contains(touchWorldPosition);
    }
}
