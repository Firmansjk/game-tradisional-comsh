using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2BarController : MonoBehaviour
{
    public Player2ButtonController player2ButtonControllerScript;
    public float speed = 5f;
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

    public void PointingScoreP2()
    {
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
