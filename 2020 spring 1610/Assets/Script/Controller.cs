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
    private Vector3 velo;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        myRigidBody.velocity = velo;
        velo = new Vector3(Input.GetAxisRaw("Horizontal"),0, Input.GetAxisRaw("Vertical")).normalized * playerSpeed;
    }
}
