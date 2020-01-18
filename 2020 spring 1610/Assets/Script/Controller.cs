using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float playerSpeed;
    public float jumpPower;
    public float jumpFall;
    public bool playerMove;
    public bool playerJump;
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
        move = new Vector3(Input.GetAxisRaw("Horizontal"),0f, Input.GetAxisRaw("Vertical"));

        
        if(Input.GetButtonDown("Jump"))
        {
            myRigidBody.velocity = Vector3.up * jumpPower;
        }
        if(myRigidBody.velocity.y < 0)
        {
            myRigidBody.velocity += Vector3.up * Physics.gravity.y * (jumpFall - 1) * Time.deltaTime;
        }
    }
    
    void FixedUpdate()
    {
        Movement(move);
    }

    void Movement(Vector3 direction)
    {
        myRigidBody.MovePosition(transform.position + (direction * playerSpeed * Time.deltaTime));
    }
}
