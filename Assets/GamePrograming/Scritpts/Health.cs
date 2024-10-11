using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxHealth;
    
    public float currentHealth;
    private Ragdoll ragdoll;
    public bool die = false;

  
    private void Start()
    {
        ragdoll = GetComponent<Ragdoll>();
      
        currentHealth = maxHealth;

        
    }

    public void TakeDamage(float amount)
    {
        currentHealth -= amount;
        if (currentHealth <= 0.0f)
        {
            Die();
        }

    
    }

    void Die()
    {
        if (!die)
        {
            GameManager.instance.OnKill();
        }
        
        ragdoll.ActivateRagdoll();
        die = true;
    }

    
}
