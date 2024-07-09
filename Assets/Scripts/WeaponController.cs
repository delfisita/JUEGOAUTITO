using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public GameObject projectilePrefab;  // Prefab del proyectil
    public Transform firePoint;          // Punto desde donde se dispara el proyectil
    public float projectileSpeed = 20f;  // Velocidad del proyectil

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // Crear el proyectil en el punto de disparo
        GameObject projectile = Instantiate(projectilePrefab, firePoint.position, firePoint.rotation);
        // Asignarle una velocidad al proyectil
        
        
    }
}
