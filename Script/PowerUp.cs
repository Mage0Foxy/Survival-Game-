using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject pickupEffect;

    public float multiplier = 20f;
    public float duration = 4f;

    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Play"))
        {
            StartCoroutine (Pickup(other));
        }
    }

    IEnumerator Pickup(Collider Play)
    {
        Instantiate(pickupEffect, transform.position, transform.rotation);

        Targeting stats = Play.GetComponent<Targeting>();
        stats.range += multiplier;

        yield return new WaitForSeconds(duration);

        stats.range -= multiplier;

        Destroy(gameObject);
    }
}
