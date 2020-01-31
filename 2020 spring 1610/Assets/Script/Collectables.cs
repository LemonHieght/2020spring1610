using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Collectables : MonoBehaviour
{
    public GameObject player;
    public UnityEvent triggerEnterEvent;
    
    private void OnTriggerEnter(Collider Player)
    {
        
        if (player)
        {
            triggerEnterEvent.Invoke();
            print("trigger");
            Destroy(this.gameObject);
        }
    }
}
