using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public int damageAmount = 10;

    void Start()
    {
        currentHealth = maxHealth;
        Debug.Log("Salud inicial: " + currentHealth);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Colisión detectada con: " + other.gameObject.name);

        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Colisión con un enemigo detectada");
            TakeDamage(damageAmount);
        }
    }

    void TakeDamage(int amount)
    {
        currentHealth -= amount;
        Debug.Log("Salud actual: " + currentHealth);

        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }

}
