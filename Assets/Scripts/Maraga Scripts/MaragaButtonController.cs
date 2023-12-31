using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaragaButtonController : MonoBehaviour
{
    //penambahan sprite
    public Sprite spriteDiam;
    public Sprite spriteTendang;
    public SpriteRenderer spriteRenderer;

    public bool animasiMenendang = false;

    public float launchSpeed = 10f;
    public bool canLaunchBall = true;

    private bool isDragging = false;
    private Vector2 dragStartPosition;

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    StartDragging(touch.position);
                    break;

                case TouchPhase.Moved:
                    if (isDragging)
                    {
                        // Calculate the swipe direction
                        Vector2 swipeDirection = touch.position - dragStartPosition;

                        // Update the rotation of the pointer for visual feedback
                        //float angle = Mathf.Atan2(swipeDirection.y, swipeDirection.x) * Mathf.Rad2Deg;
                        //transform.rotation = Quaternion.Euler(0f, 0f, angle);
                    }
                    break;

                case TouchPhase.Ended:
                    EndDragging(touch.position);
                    break;
            }
        }
    }

    void StartDragging(Vector2 position)
    {
        isDragging = true;
        dragStartPosition = position;
    }

    void EndDragging(Vector2 position)
    {
        if (isDragging)
        {
            isDragging = false;

            // Reset the rotation of the pointer after the drag ends
            transform.rotation = Quaternion.identity;

            // Calculate the swipe direction
            Vector2 swipeDirection = position - dragStartPosition;
            if (canLaunchBall == true)
            {
                // Launch the ball based on the swipe direction
                LaunchBall(swipeDirection.normalized);
                canLaunchBall = false;
            }
        }
    }

    void LaunchBall(Vector2 launchDirection)
    {
        GameObject ball = GameObject.Find("Bola"); // Replace "Bola" with the actual name of your ball object

        // Check if the ball GameObject is found
        if (ball != null)
        {
            Rigidbody2D ballRb = ball.GetComponent<Rigidbody2D>();

            // Adjust the launch speed based on your needs
            ballRb.velocity = launchDirection * launchSpeed;

            //animasi menendang
            if (animasiMenendang)
            {
                KickAnimation();
            }
        }
        else
        {
            Debug.LogError("Ball GameObject not found. Make sure the correct name is used.");
        }
    }
    //peralihan animasi
    public void IdleAnimation()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        this.spriteRenderer.sprite = spriteDiam;
    }
    public void KickAnimation()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        this.spriteRenderer.sprite = spriteTendang;
    }
}
