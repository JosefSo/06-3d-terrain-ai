using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCaim : MonoBehaviour
{
    public Transform player; // The player object.
    public GunController gun; // The gun object.

    void Update()
    {
        // Rotate the NPC to face the player.
        transform.LookAt(player);

        // Fire the gun.
        if (Vector3.Distance(transform.position, player.position) < 20) // Only fire if the player is within 20 units.
        {
            gun.Fire();
        }
    }
}
