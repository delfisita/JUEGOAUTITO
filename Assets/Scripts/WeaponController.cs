using UnityEngine;


public class Projectile : MonoBehaviour
{
    public float destroyTime = 5f; // Tiempo antes de que el proyectil se destruya automáticamente

    void Start()
    {
        // Destruir el proyectil después de un tiempo si no colisiona con nada
        Destroy(gameObject, destroyTime);
    }

    void OnTriggerEnter(Collider other)
    {
        // Si el proyectil colisiona con un enemigo
        if (other.CompareTag("Enemy"))
        {
            // Destruir al enemigo
            Destroy(other.gameObject);
            // Destruir el proyectil
            Destroy(gameObject);
        }
        else if (!other.CompareTag("Player")) // Evita destruir el proyectil si colisiona con el jugador
        {
            // Destruir el proyectil en cualquier otra colisión
            Destroy(gameObject);
        }
    }
}
