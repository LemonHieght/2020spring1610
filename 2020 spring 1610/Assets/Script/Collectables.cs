using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class Collectables : MonoBehaviour
{
    public GameObject player;
    public UnityEvent triggerEnterEvent;
    public GameObject collectObject;
    public Transform items;
    
    private void OnTriggerEnter(Collider theCollision)
    {
        
        if (theCollision.gameObject.tag == "Character" )
        {
            triggerEnterEvent.Invoke();
            print("trigger"); 
            gameObject.SetActive(false);
            Instantiate(collectObject, items.position , items.rotation);
        }
    }
}
