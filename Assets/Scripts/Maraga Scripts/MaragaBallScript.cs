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

    void Start()
    {
        if (points.Length < 4)
        {
            Debug.LogError("Please assign at least 4 points in the inspector.");
            return;
        }

        // Set initial start and end positions
        SetStartAndEndPositions();

        // Randomize height and speed within the specified range
        height = Random.Range(minHeight, maxHeight);
        speed = Random.Range(minSpeed, maxSpeed);
    }

    void Update()
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
            // Arrived at the destination, set the next start and end positions cyclically
            SetStartAndEndPositions();

            // Randomize height and speed for the next segment
            height = Random.Range(minHeight, maxHeight);
            speed = Random.Range(minSpeed, maxSpeed);
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
