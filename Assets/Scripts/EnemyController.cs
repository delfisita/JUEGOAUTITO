using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float detectionRange = 10f; 
    public float moveSpeed = 5f;

    private Transform playerTransform; 
    private bool isChasing = false; 

    void Start()
    {
        
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;

        if (playerTransform == null)
        {
            Debug.LogError("No se encontró al jugador. Asegúrate de etiquetar al jugador como 'Player'.");
        }
    }

    void Update()
    {
        if (playerTransform == null)
            return; 

       
        float distanceToPlayer = Vector3.Distance(transform.position, playerTransform.position);

       
        if (distanceToPlayer <= detectionRange)
        {
            StartChasing();
        }
        else
        {
            StopChasing();
        }

        
        if (isChasing)
        {
            Vector3 direction = (playerTransform.position - transform.position).normalized;
            transform.position += direction * moveSpeed * Time.deltaTime;

           
            transform.LookAt(playerTransform);
        }
    }

    void StartChasing()
    {
        isChasing = true;
        
    }

    void StopChasing()
    {
        isChasing = false;
        
    }
}

