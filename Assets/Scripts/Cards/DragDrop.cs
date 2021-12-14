using System;
using Cards;
using Managers;
using UnityEngine;

public class DragDrop : MonoBehaviour
{
    private bool isDragging = false;

    private Vector2 startPosition;

    private void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        if (isDragging)
        {
            transform.position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        }
        else
        {
            transform.position = Vector2.Lerp(transform.position, startPosition, Time.deltaTime);
        }
    }

    public void StartDrag()
    {
        isDragging = true;
        GameManager.Instance.CurrentCard = GetComponentInParent<ICard>();
    }

    public void StopDrag()
    {
        isDragging = false;
        GameManager.Instance.CurrentCard = null;
    }
}
