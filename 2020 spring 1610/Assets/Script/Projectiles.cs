using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectiles : MonoBehaviour
{
    public float speed;
    private Rigidbody bulletBody;
    private Vector3 screenLimit;
    public float bulletTimmer;


    private void Start()
    {
        bulletBody = this.GetComponent<Rigidbody>();
        bulletBody.velocity = transform.forward * speed;
        screenLimit = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
    }

    // Update is called once per frame
    void Update()
    {
        // if (transform.position.x > screenLimit.x * -2);
        // {
        //     gameObject.SetActive(false);
        //     print("you stupid");
        // }
        if(bulletTimmer > 0)
        {
            bulletTimmer -= Time.deltaTime;
        }
        
        if (bulletTimmer <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "enemy")
        {
            print("die");
        }
    }
}
