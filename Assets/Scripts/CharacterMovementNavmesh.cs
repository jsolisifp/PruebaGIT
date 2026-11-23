using UnityEngine;
using UnityEngine.AI;

public class CharacterMovementNavmesh : MonoBehaviour
{
    public Transform target;
    public NavMeshAgent agent;
    public Animator animator;

    float cooldown;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cooldown = cooldown - Time.deltaTime;

        if(cooldown <= 0)
        {
            agent.SetDestination(target.position);
            cooldown = 0.5f;

        }

        float speed;
        speed = agent.velocity.magnitude;

        animator.SetFloat("Speed", speed);

    }
}
