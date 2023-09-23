using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public Transform[] possibleStartPoints; // Array of possible starting points
    public Transform[] possibleEndPoints;   // Array of possible target points
    public float minHeight = 5f;            // Minimum height of the parabola
    public float maxHeight = 8f;            // Maximum height of the parabola
    public float minSpeed = 5f;             // Minimum speed of movement
    public float maxSpeed = 8f;             // Maximum speed of movement

    private Vector3 startPos;
    private Vector3 endPos;
    private float journeyLength;
    private float startTime;
    private int previousEndIndex; // Store the previous endIndex
    private float height;
    private float speed;

    void Start()
    {
        if (possibleStartPoints.Length == 0 || possibleEndPoints.Length == 0)
        {
            Debug.LogError("Please assign possible starting and target points in the inspector.");
            return;
        }

        // Randomly select start and end points
        int startIndex = Random.Range(0, possibleStartPoints.Length);
        int endIndex = Random.Range(0, possibleEndPoints.Length);

        startPos = possibleStartPoints[startIndex].position;
        endPos = possibleEndPoints[endIndex].position;
        journeyLength = Vector3.Distance(startPos, endPos);
        startTime = Time.time;

        // Initialize the previousEndIndex
        previousEndIndex = endIndex;

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
            // Arrived at the destination, select new random points
            int endIndex;
            do
            {
                endIndex = Random.Range(0, possibleEndPoints.Length);
            } while (endIndex == previousEndIndex); // Ensure endIndex is different from the previous endIndex

            startPos = possibleEndPoints[previousEndIndex].position;
            endPos = possibleEndPoints[endIndex].position;
            journeyLength = Vector3.Distance(startPos, endPos);
            startTime = Time.time;

            // Update the previousEndIndex
            previousEndIndex = endIndex;

            // Randomize height and speed for the next segment
            height = Random.Range(minHeight, maxHeight);
            speed = Random.Range(minSpeed, maxSpeed);
        }
    }
}
