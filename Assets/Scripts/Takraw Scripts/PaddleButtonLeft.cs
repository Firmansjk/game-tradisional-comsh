using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleButtonLeft : MonoBehaviour
{
    public PaddleController paddleControllerScript;
    public float speed = 5f;  // Adjust the speed as needed
    public float lerpSpeed = 5f;  // Adjust the lerp speed as needed
    private bool isButtonPressed = false;

    public void OnMouseDown()
    {
        Vector3 targetPosition = transform.position + Vector3.left * speed * Time.deltaTime;
        paddleControllerScript.gameObject.transform.position = Vector3.Lerp(transform.position, targetPosition, lerpSpeed * Time.deltaTime);
    }
}
