using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float playerSpeed;
    public float jumpPower;
    public bool playerMove;
    public bool playerJump;
    private Rigidbody myRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        playerMove = false;

        if(Input.GetAxisRaw("Horizontal")> 0.5f || Input.GetAxisRaw("Horizontal")< -0.5f)
        {
            myRigidBody.velocity = new Vector3(Input.GetAxisRaw("Horizontal") * playerSpeed, myRigidBody.velocity.y);
            playerMove = true;
        }
        if(Input.GetAxisRaw("Vertical")> 0.5f || Input.GetAxisRaw("Vertical")< -0.5f)
        {
            myRigidBody.velocity = new Vector3(Input.GetAxisRaw("Vertical") * playerSpeed, myRigidBody.velocity.x);
            playerMove = true;
        }
    }
}
