using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject Enemy;
    public float timer=5.0f;
    private void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0.0f)
        {
            Instantiate(Enemy, transform.position, Quaternion.identity);
            timer = 5.0f;
        }
        
    }
}
