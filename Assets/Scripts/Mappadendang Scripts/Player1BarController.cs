using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1BarController : MonoBehaviour
{
    public Player1ButtonController player1ButtonControllerScript;
    public float speed = 5f; 
    public float maxRightPosition;
    public float maxLeftPosition;
    public GameObject targetP1;
    public Button buttonP1;
    public bool canPoint;

    private bool movingRight = true;

    private void Update()
    {
        if (movingRight)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            if (transform.position.x >= maxRightPosition)
            {
                movingRight = false; 
            }
        }
        else
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            if (transform.position.x <= maxLeftPosition)
            {
                movingRight = true;
            }
        }


    }

    public void PointingScoreP1()
    {
        if (canPoint)
        {
            player1ButtonControllerScript.AddScoreP1();
        }
        if (!canPoint)
        {
            player1ButtonControllerScript.MinusScoreP1();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == targetP1)
        {
            canPoint = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject == targetP1)
        {
            canPoint = false;
        }
    }
}
