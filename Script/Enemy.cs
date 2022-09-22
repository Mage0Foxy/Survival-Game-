using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5f;

    private Transform target;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Play").GetComponent<Transform>();
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);
    }
    void OnCollisionEnter(Collision collision)
    {
        // You probably want a check here to make sure you're hitting a zombie
        // Note that this is not the best method for doing so.
        if (collision.collider.tag == "Bullet")
        {
            Destroy(this.gameObject);
        }
    }
}
