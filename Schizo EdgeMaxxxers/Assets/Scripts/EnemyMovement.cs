using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyMovement : MonoBehaviour
{

    public int Damage;

    public int health;

    public Transform player;

    Animator animator;

    private NavMeshAgent navMeshAgent;

    NavMeshAgent agent;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    public void TakeDamage()
    {
        health -= Damage;
        if(health <= 0) Invoke(nameof(DestroyEnemy), 5f);
    }

    void DestroyEnemy()
    {
        Destroy(gameObject);
    }

    void Update()
    {

        animator.SetFloat("Speed",agent.velocity.magnitude);
        if (player != null)
        {
            navMeshAgent.SetDestination(player.position);
        }
    }


}
