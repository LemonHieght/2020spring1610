using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastFire : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPreFab;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(bulletPreFab, firePoint.position, firePoint.rotation);
    }
}
