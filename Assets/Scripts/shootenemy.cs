using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootenemy : MonoBehaviour
{
    public GameObject projectilePrefab;
    public Transform firePoint;
    public float fireRate = 1f;
    public float projectileSpeed = 20f;
    public Transform player;

    private float nextFireTime = 0f;

    void Update()
    {
        if (Time.time >= nextFireTime && Vector3.Distance(player.position, transform.position) <= 15f)
        {
            Shoot();
            nextFireTime = Time.time + 1f / fireRate;
        }
    }

    void Shoot()
    {
        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        rb.velocity = (player.position - firePoint.position).normalized * projectileSpeed;
    }
}
