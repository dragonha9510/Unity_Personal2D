using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] private Transform targetTransform;
    [SerializeField] private float followRange;
    [SerializeField] private float speed = 2;

    private void Start()
    {
        if (targetTransform == null)
            targetTransform = GameObject.Find("Player_CameraBox").transform;
    }

    private void Update()
    {
        Vector2 direction = targetTransform.position - transform.position;

        direction = direction / followRange;

        transform.position += new Vector3(direction.x, direction.y, 0) * Time.deltaTime * speed;
    }
}
