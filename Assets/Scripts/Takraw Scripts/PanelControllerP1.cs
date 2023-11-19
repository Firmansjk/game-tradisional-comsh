using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class PanelControllerP1 : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler
{
    public GameObject paddle; // Reference to your paddle GameObject
    private bool isDragging = false;
    private Vector3 offset;
    public float moveSpeed = 5f; // Adjust this speed as needed

    public void OnPointerDown(PointerEventData eventData)
    {
        // Set the dragging flag to true when the panel is touched
        isDragging = true;

        // Calculate the offset between the paddle's position and the touch position
        offset = paddle.transform.position - Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        // Set the dragging flag to false when the touch is released
        isDragging = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (isDragging)
        {
            // Move the paddle smoothly using Vector3.Lerp
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            Vector3 newPosition = new Vector3(touchPosition.x + offset.x, paddle.transform.position.y, paddle.transform.position.z);

            paddle.transform.position = Vector3.Lerp(paddle.transform.position, newPosition, moveSpeed * Time.deltaTime);
        }
    }
}
