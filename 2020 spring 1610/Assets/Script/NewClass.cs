﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewClass : MonoBehaviour
{
    public int cash;
    //whole numbers
    public float coin;
    //fraction numbers
    public string money;
    //words
    public string nameString;
    public bool rich;
    //true or false
    
    // public UnityEngine.Event uEvent;

    // Start is called before the first frame update
    void Start()
    //Nothing Whatever
    {
        print("Nothing Whatever");
        print(nameString);
        // uEvent.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        print("NOTHING WHATEVER!!!!!!!!!!!!!!");

      
    }
}
        // //this is old movement
        // move = new Vector3(Input.GetAxisRaw("Horizontal"),0f, Input.GetAxisRaw("Vertical")).normalized* playerSpeed;
        // myRigidBody.velocity = move;
        
        // if(move != Vector3.zero)
        // {
        //     transform.forward = move;
        // }