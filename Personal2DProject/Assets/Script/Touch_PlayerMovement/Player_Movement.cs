using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    [SerializeField, Range(0, 1)] private float speed;
    private Vector2 direction;
    public Vector2 info { get { return direction; } set { direction = value; } }

    public void Update()
    {
        if (direction == Vector2.zero)
            return;

        transform.position += new Vector3(direction.x, direction.y, 0) * speed * 0.1f;
    }
}
