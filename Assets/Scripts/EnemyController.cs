using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform[] patrolPoints;
    private int currentPatrolIndex;
    public float patrolSpeed = 3.5f;
    public float chaseSpeed = 6f;
    public float detectionRange = 20f;
    public Transform player;

    private NavMeshAgent agent;
    private bool isChasing = false;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = patrolSpeed;
        GotoNextPatrolPoint();
    }

    void Update()
    {
        if (Vector3.Distance(player.position, transform.position) <= detectionRange)
        {
            StartChasing();
        }
        else
        {
            StopChasing();
        }

        if (!isChasing)
        {
            if (!agent.pathPending && agent.remainingDistance < 0.5f)
            {
                GotoNextPatrolPoint();
            }
        }
        else
        {
            agent.SetDestination(player.position);
        }
    }

    void GotoNextPatrolPoint()
    {
        if (patrolPoints.Length == 0)
            return;

        agent.destination = patrolPoints[currentPatrolIndex].position;
        currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length;
    }

    void StartChasing()
    {
        isChasing = true;
        agent.speed = chaseSpeed;
    }

    void StopChasing()
    {
        isChasing = false;
        agent.speed = patrolSpeed;
        GotoNextPatrolPoint();
    }
}
