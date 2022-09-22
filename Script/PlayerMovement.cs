using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    float moveSpeed = 0.25f;

    Vector3 targetPosition;

    bool moving;

    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            transform.position += Vector3.forward;
            moving = true;
        }
        if (Input.GetKeyDown("s"))
        {
            transform.position += Vector3.back;
            moving = true;
        }
        if (Input.GetKeyDown("a"))
        {
            transform.position += Vector3.left;
            moving = true;
        }
        if (Input.GetKeyDown("d"))
        {
            transform.position += Vector3.right;
            moving = true;
        }

    }


}
