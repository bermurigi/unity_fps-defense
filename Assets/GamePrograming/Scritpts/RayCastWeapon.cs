using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastWeapon : MonoBehaviour
{
    class Bullet
    {
        public float time;
        public Vector3 initialPostiion;
        public Vector3 initialVelocity;
        public TrailRenderer tracer;
        public int bounce;
    }

    public int fireRate=25;
    public float bulletSpeed = 1000.0f;
    public float bulletDrop = 0.0f;
    public int maxBounces = 0;
    public ParticleSystem[] muzzleFlash;
    public ParticleSystem hitEffect;
    public TrailRenderer tracerEffect;
    public float damage = 10;

    public Transform raycastOrigin;
    public Transform raycastDestination;
    private Ray ray;
    private RaycastHit hitInfo;
    private List<Bullet> bullets = new List<Bullet>();

    Vector3 GetPosition(Bullet bullet)
    {
        Vector3 gravity=Vector3.down*bulletDrop;
        return (bullet.initialPostiion) + (bullet.initialVelocity * bullet.time) +
               (0.5f * gravity * bullet.time * bullet.time);
    }

    Bullet CreateBullet(Vector3 position, Vector3 velocity)
    {
        Bullet bullet = new Bullet();
        bullet.initialPostiion = position;
        bullet.initialVelocity = velocity;
        bullet.time = 0.0f;
        bullet.tracer = Instantiate(tracerEffect, position, Quaternion.identity);
        bullet.tracer.AddPosition(position);
        bullet.bounce = maxBounces;
        return bullet;
    }

    public void Fire()
    {
        if (Input.GetMouseButton(0))
        {
            
        }
    }
    //9:47https://www.youtube.com/watch?v=oLT4k-lrnwg&list=PLyBYG1JGBcd009lc1ZfX9ZN5oVUW7AFVy&index=2

    // Update is called once per frame
    void Update()
    {
        
        
    }
}
