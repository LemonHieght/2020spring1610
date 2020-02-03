using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
    public float speed;
    private Rigidbody bulletBody;
    public float bulletTimmer;
    public int damage;


    private void Start()
    {
        bulletBody = this.GetComponent<Rigidbody>();
        bulletBody.velocity = transform.forward * speed;
    }

    // Update is called once per frame
    void Update()
    {
        if(bulletTimmer > 0)
        {
            bulletTimmer -= Time.deltaTime;
        }
        
        if (bulletTimmer <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            Destroy(gameObject);
        }

        if (hitInfo.gameObject.tag == "Enviroment")
        {
            Destroy(gameObject);
        }
    }
}
