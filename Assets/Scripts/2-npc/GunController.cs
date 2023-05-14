using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunController : MonoBehaviour
{
    public Transform firePoint; // The point from which bullets are fired.
    public GameObject bulletPrefab; // The bullet object that is fired.

    public float fireRate = 1f; // The rate at which the gun can fire, in shots per second.
    private float nextFireTime = 0f; // The time at which the gun can fire next.

    public void Fire()
    {
        // Check if it's time to fire again.
        if (Time.time >= nextFireTime)
        {
            // Instantiate a new bullet at the fire point.
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            
            // Update the next fire time.
            nextFireTime = Time.time + 1f / fireRate;
        }
    }
}
