using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rig;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MoveObject(GetTouchInput());
    }

    private Vector2 GetTouchInput()
    {
        Vector2 movement = Vector2.zero;

        if (Input.touchCount > 0)
        {
            // Get the first touch (you can expand this for multiple touches)
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                // Calculate the movement based on touch position delta
                movement = new Vector2(touch.deltaPosition.x, touch.deltaPosition.y) * speed;
            }
        }

        return movement;
    }

    private void MoveObject(Vector2 movement)
    {
        rig.velocity = movement;
    }
}
