﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float playerSpeed;
    public float jumpPower;
    public float jumpFall;
    public bool grounded;
    public bool snowGoggles;
    private Rigidbody myRigidBody;
    private Vector3 move;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void Update()
    {
        //move input
        move = new Vector3(Input.GetAxisRaw("Horizontal"),0f, Input.GetAxisRaw("Vertical"));

        //jump
        if(Input.GetButtonDown("Jump") && grounded)
        {
            myRigidBody.velocity = Vector3.up * jumpPower;
            grounded = false;
        }
        //fall
        if(myRigidBody.velocity.y < 0)
        {
            myRigidBody.velocity += Vector3.up * Physics.gravity.y * (jumpFall - 1) * Time.deltaTime;
        }
    }
    //FixedUpdate is called every physics update
    void FixedUpdate()
    {
        Movement(move);
    }
    //move
    void Movement(Vector3 direction)
    {
        myRigidBody.MovePosition(transform.position + (direction * playerSpeed * Time.deltaTime));
    }
    
    void OnCollisionStay()
    {
        grounded = true;
    }

}
