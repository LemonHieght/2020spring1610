using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Collectables : MonoBehaviour
{
    public GameObject player;
    public UnityEvent triggerEnterEvent;
    
    private void OnTriggerEnter(Collider theCollision)
    {
        
        if (theCollision.gameObject.tag == "Character" )
        {
            triggerEnterEvent.Invoke();
            print("trigger");
            Destroy(this.gameObject);
        }
    }
}
