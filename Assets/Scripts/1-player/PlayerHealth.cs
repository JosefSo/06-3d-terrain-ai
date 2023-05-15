using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health;

    public void TakeDamage(int amount)
    {
        Debug.Log("TakeDamage function called. Amount: " + amount); // Log message to the console


        health -= amount;
        if (health <= 0)
        {
            // Handle player death...
            Debug.Log("Player has died"); // Log message to the console when player dies
        }
    }
}
