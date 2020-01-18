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
    private Vector3 velo;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        velo = new Vector3(Input.GetAxisRaw("Horizontal"),0, Input.GetAxisRaw("Vertical")).normalized * playerSpeed;
        myRigidBody.velocity = velo;
        
        if(velo != Vector3.zero)
        {
            transform.forward = velo;
        }

    
    }
}
