using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseHealth : MonoBehaviour
{
    public int health;

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            // Handle Base death...
            Debug.Log("Base burned"); // Log message to the console when Base dies
        }
    }
}
