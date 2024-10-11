using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AILocomotion : MonoBehaviour
{
    private NavMeshAgent agent;
    public Transform playerTransform;
    public float maxTime=1.0f;
    public float maxDistance=1.0f;
    private Animator animator;
    private float timer = 0.0f;
    public Health health;
    private Collider[] colliders;
    public int damage=10;
    public float attactTime = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerTransform = player.GetComponent<Transform>();
        
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        health = GetComponent<Health>();
      

    }

    // Update is called once per frame
    void Update()
    {
        
        if (health.die)
        {
            agent.destination = agent.transform.position;
            
            return;
        }
        timer -= Time.deltaTime;
        float distanceToPlayer = Vector3.Distance(transform.position, playerTransform.position);
        
        if (distanceToPlayer <= 2f)
        {
            Debug.Log(distanceToPlayer);
            animator.SetTrigger("Attack");
            agent.destination = agent.transform.position;
            
            attactTime -= Time.deltaTime;
            if (attactTime <= 0.0f)
            {
                playerTransform.GetComponent<Player>().TakeDamage(damage);
                attactTime = 0.5f;
            }
            
            
                
                
            
            
        }
        else
        {
            attactTime = 0.5f;
            animator.ResetTrigger("Attack");
            if(timer < 0.0f)
            {
                float sqdistance = (playerTransform.position - agent.destination).magnitude;
                if (sqdistance > maxDistance*maxDistance)
                {
                    agent.destination = playerTransform.position;
                }

                timer = maxTime;
                animator.SetFloat("Speed",agent.velocity.magnitude);

            }
        }
        
        
        
        
        

    }
}
