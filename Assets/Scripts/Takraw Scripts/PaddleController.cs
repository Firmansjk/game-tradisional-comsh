using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public float speed;
    public KeyCode upKey;
    public KeyCode downKey;

    private Rigidbody2D rig;
    private Vector3 originalSize;
    private float originalSpeed;

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MoveObject(GetInput());
    }

    private Vector2 GetInput()
    {
        if (Input.GetKey(upKey))
        {
            return Vector3.up * speed;
        }
        else if (Input.GetKey(downKey))
        {
            return Vector3.down * speed;
        }

        return Vector2.zero;
    }

    private void MoveObject(Vector2 movement)
    {
        Debug.Log("TEST: " + movement);
        //transform.Translate(movement * Time.deltaTime);
        rig.velocity = movement;
    }
}
