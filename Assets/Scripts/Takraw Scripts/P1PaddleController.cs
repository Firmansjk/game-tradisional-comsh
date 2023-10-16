using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1PaddleController : MonoBehaviour
{
    private Vector3 touchStartPos;
    private Vector3 objectStartPos;
    private bool isDragging = false;

    private Vector3 defaultPosition;

    private void Start()
    {
        defaultPosition = transform.position;
    }

    public void ResetPaddle()
    {
        transform.position = defaultPosition;
    }

    private void OnMouseDown()
    {
        if (Input.touchCount > 0)
        {
            touchStartPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
        }
        else
        {
            touchStartPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        objectStartPos = transform.position;
        isDragging = true;
    }

    private void OnMouseDrag()
    {
        if (isDragging)
        {
            Vector3 currentPos;

            if (Input.touchCount > 0)
            {
                currentPos = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
            }
            else
            {
                currentPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            }

            transform.position = objectStartPos + (currentPos - touchStartPos);
        }
    }

    private void OnMouseUp()
    {
        isDragging = false;
    }
}