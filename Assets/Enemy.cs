using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform target;
    public float speed;
    Rigidbody rb;
    NavMeshAgent agent;
    public float viewDistance;
    public float wanderDistance;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        agent = GetComponent<NavMeshAgent>();
        agent.speed = speed;
    }

    void Update()
    {
        var distance = Vector3.Distance(transform.position, target.position);

        if (distance < viewDistance)
        {
            agent.destination = target.position;
        }
        else 
        {
            if (agent.velocity == Vector3.zero)
            {
                var offset = Random.insideUnitSphere * wanderDistance;
                agent.destination = transform.position + offset;
            }
        }

        if (distance < 1f)
        {
            // jumpscare
        }
    }
}
