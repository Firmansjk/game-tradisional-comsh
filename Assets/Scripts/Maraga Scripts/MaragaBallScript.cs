using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaragaBallScript : MonoBehaviour
{
    public Transform[] points; // Array of possible points
    public float minHeight = 5f; // Minimum height of the parabola
    public float maxHeight = 8f; // Maximum height of the parabola
    public float minSpeed = 5f; // Minimum speed of movement
    public float maxSpeed = 8f; // Maximum speed of movement

    private int currentPointIndex = 0;
    private Vector3 startPos;
    private Vector3 endPos;
    private float journeyLength;
    private float startTime;
    private float height;
    private float speed;

    private bool isMoving = false;

    void Start()
    {
        if (points.Length < 4)
        {
            Debug.LogError("Please assign at least 4 points in the inspector.");
            return;
        }

        // Set initial start and end positions
        currentPointIndex = 0; // Set the current point index to 0 (point 1)
        SetStartAndEndPositions();

        // Randomize height and speed within the specified range
        height = Random.Range(minHeight, maxHeight);
        speed = Random.Range(minSpeed, maxSpeed);

        // Set the initial position of the ball to the first point
        MoveToTargetPoint(currentPointIndex-1);
    }

    void Update()
    {
        if (IsMoving)
        {
            float distanceCovered = (Time.time - startTime) * speed;
            float fractionOfJourney = distanceCovered / journeyLength;

            // Calculate the parabolic motion
            float yOffset = height * Mathf.Sin(fractionOfJourney * Mathf.PI);
            Vector3 newPosition = Vector3.Lerp(startPos, endPos, fractionOfJourney) + Vector3.up * yOffset;

            // Update the object's position
            transform.position = newPosition;

            if (fractionOfJourney >= 1f)
            {
                // Arrived at the destination, stop moving
                IsMoving = false;
            }
        }
    }

    public void MoveToTargetPoint(int targetPointIndex)
    {
        if (IsMoving)
        {
            // Game over condition: Player pressed the button while the object was moving
            Debug.Log("Game Over");
            return;
        }

        if (targetPointIndex < 0 || targetPointIndex >= points.Length)
        {
            Debug.LogError("Invalid target point index.");
            return;
        }

        // Set the target point and start moving
        currentPointIndex = targetPointIndex;
        SetStartAndEndPositions();
        height = Random.Range(minHeight, maxHeight);
        speed = Random.Range(minSpeed, maxSpeed);
        IsMoving = true;
    }

    public bool IsMoving
    {
        get
        {
            return isMoving;
        }

        set
        {
            isMoving = value;
        }
    }
    public int CurrentPointIndex
    {
        get 
        { 
            return currentPointIndex; 
        }
    }

    private void SetStartAndEndPositions()
    {
        startPos = points[currentPointIndex].position;
        currentPointIndex = (currentPointIndex + 1) % points.Length; // Move to the next point cyclically
        endPos = points[currentPointIndex].position;
        journeyLength = Vector3.Distance(startPos, endPos);
        startTime = Time.time;
    }
}
