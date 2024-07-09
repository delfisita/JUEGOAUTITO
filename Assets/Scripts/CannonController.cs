using UnityEngine;

public class CannonController : MonoBehaviour
{
    public GameObject projectilePrefab;  // Prefab del proyectil
    public Transform firePoint;          // Punto desde donde se dispara el proyectil
   

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
      
        
    }
}
