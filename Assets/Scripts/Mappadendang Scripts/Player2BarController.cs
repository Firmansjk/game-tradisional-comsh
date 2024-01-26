using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2BarController : MonoBehaviour
{
    public Player2ButtonController player2ButtonControllerScript;
    public float speed = 5f; // Adjust the speed as needed
    public float maxRightPosition;
    public float maxLeftPosition;
    public GameObject targetP2;
    public Button buttonP2;
    public bool canPoint;

    private bool movingRight = true;

    private void Update()
    {
        if (movingRight)
        {
            // Move towards the right
            transform.Translate(Vector3.right * speed * Time.deltaTime);

            // Check if the object reached x
            if (transform.position.x >= maxRightPosition)
            {
                movingRight = false; // Change direction
            }
        }
        else
        {
            // Move towards the left
            transform.Translate(Vector3.left * speed * Time.deltaTime);

            // Check if the object reached x=0
            if (transform.position.x <= maxLeftPosition)
            {
                movingRight = true; // Change direction
            }
        }


    }

    public void PointingScoreP2()
    {
        //pointing
        if (canPoint)
        {
            player2ButtonControllerScript.AddScoreP2();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == targetP2)
        {
            canPoint = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == targetP2)
        {
            canPoint = false;
        }
    }
}
