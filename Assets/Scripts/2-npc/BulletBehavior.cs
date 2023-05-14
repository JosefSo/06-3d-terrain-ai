using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour
{   
    [SerializeField]
    public float speed = 20f; // The speed at which the bullet travels.
    [SerializeField]
    public int damage = 1; // The amount of damage the bullet does.

    void Update()
    {
        // Move the bullet forward.
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        // If the bullet hits the player, reduce the player's health.
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);
        }

        // Destroy the bullet on collision.
        Destroy(gameObject);
    }
}
