using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1CharController : MonoBehaviour
{
    private int touchID = -1;
    private Vector2 touchStartPosition;
    private bool isBeingTouched;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        foreach (Touch touch in Input.touches)
        {
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    if (IsTouchingObject(touch.position))
                    {
                        isBeingTouched = true;
                        touchID = touch.fingerId;
                        touchStartPosition = touch.position;
                    }
                    break;

                case TouchPhase.Moved:
                    if (isBeingTouched && touch.fingerId == touchID)
                    {
                        Vector2 touchDelta = touch.position - touchStartPosition;
                        rb.AddForce(touchDelta * Time.deltaTime, ForceMode2D.Impulse);
                        touchStartPosition = touch.position;
                    }
                    break;

                case TouchPhase.Ended:
                    if (isBeingTouched && touch.fingerId == touchID)
                    {
                        isBeingTouched = false;
                        touchID = -1;
                    }
                    break;
            }
        }
    }

    bool IsTouchingObject(Vector2 touchPosition)
    {
        Vector2 touchWorldPosition = Camera.main.ScreenToWorldPoint(touchPosition);
        Collider2D collider = GetComponent<Collider2D>();
        return collider.bounds.Contains(touchWorldPosition);
    }
}
