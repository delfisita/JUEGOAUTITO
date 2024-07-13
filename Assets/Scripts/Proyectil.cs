using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour
{

    public float speed = 20f;
    public float lifeTime = 5f;


    private void Start()
    {
        Destroy(gameObject, lifeTime);
    }
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            // Acceder al GameManager y actualizar el contador de enemigos
            GameManager gameManager = FindObjectOfType<GameManager>();
            if (gameManager != null)
            {
                gameManager.EnemyDestroyed();
            }
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>();
            if (scoreManager != null)
            {
                scoreManager.AddScore(100);
            }
            Destroy(other.gameObject); // Destruye al enemigo
            Destroy(gameObject); // Destruye el proyectil
        }
    }


}