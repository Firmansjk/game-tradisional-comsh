using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class P1CharController : MonoBehaviour
{
    public float speed = 5f; 

    //penambahan sprite
    public Sprite spriteDiam;
    public Sprite spriteTendang;
    public SpriteRenderer spriteRenderer;

    private bool isMovingLeft = false;
    private bool isMovingRight = false;
    private bool isMovingUp = false;
    private bool isMovingDown = false;

    void Update()
    {
        // Move the paddle based on button input
        if (isMovingLeft)
            MoveLeft();

        if (isMovingRight)
            MoveRight();

        if (isMovingUp)
            MoveUp();

        if (isMovingDown)
            MoveDown();
    }

    public void StartMovingLeft()
    {
        isMovingLeft = true;
    }
    public void StopMovingLeft()
    {
        isMovingLeft = false;
    }
    public void StartMovingRight()
    {
        isMovingRight = true;
    }
    public void StopMovingRight()
    {
        isMovingRight = false;
    }
    public void StartMovingUp()
    {
        isMovingUp = true;
    }
    public void StopMovingUp()
    {
        isMovingUp = false;
    }
    public void StartMovingDown()
    {
        isMovingDown = true;
    }
    public void StopMovingDown()
    {
        isMovingDown = false;
    }
    private void MoveLeft()
    {
        Vector3 newPosition = transform.position + new Vector3(-1, 0f, 0f) * speed * Time.deltaTime;
        // Apply the new position
        transform.position = newPosition;
    }
    private void MoveRight()
    {
        Vector3 newPosition = transform.position + new Vector3(1, 0f, 0f) * speed * Time.deltaTime;
        // Apply the new position
        transform.position = newPosition;
    }
    private void MoveUp()
    {
        Vector3 newPosition = transform.position + new Vector3(0f, 1, 0f) * speed * Time.deltaTime;
        // Apply the new position
        transform.position = newPosition;
    }
    private void MoveDown()
    {
        Vector3 newPosition = transform.position + new Vector3(0f, -1, 0f) * speed * Time.deltaTime;
        // Apply the new position
        transform.position = newPosition;
    }

    public void IdleAnimation()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        this.spriteRenderer.sprite = spriteDiam;
    }
    public void KickAnimation()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        this.spriteRenderer.sprite = spriteTendang;
        Invoke("IdleAnimation", 0.5f);
    }
}
