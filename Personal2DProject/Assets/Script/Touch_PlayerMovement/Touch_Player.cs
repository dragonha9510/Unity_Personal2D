using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Touch_Player : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField] private float stopRange = 0;
    [SerializeField] private Player_Movement movement;
    private Vector2 startPosition;
    private Vector2 direction;

    public void OnBeginDrag(PointerEventData eventData)
    {
        startPosition = eventData.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        direction = eventData.position - startPosition;

        float length = direction.magnitude;

        direction = direction.normalized;

        if (length < stopRange)
            direction = Vector2.zero;

        movement.info = direction;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        startPosition = Vector2.zero;
        direction = Vector2.zero;
        movement.info = direction;
    }
}
