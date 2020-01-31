using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireGun : MonoBehaviour
{
    public GameObject firePoint;
    public GameObject bulletPreFab;
    
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            ShootBullet();
        }
    }

    void ShootBullet()
    {
        GameObject b = Instantiate(bulletPreFab) as GameObject;
        b.transform.position = firePoint.transform.position;
    }
}
