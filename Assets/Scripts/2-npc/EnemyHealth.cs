using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health;

    public void TakeDamage(int amount)
    {

        health -= amount;
        if (health <= 0)
        {
            // Handle enemy death...
            Debug.Log("Player has died"); // Log message to the console when enemy dies
        }
    }
}
