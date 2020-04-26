using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float playerSpeed;
    public float jumpPower;
    public float jumpFall;
    public bool grounded;
    public bool alive = true;
    public FloatData healthBar;
    public float health;
    private Rigidbody myRigidBody;
    private Vector3 move;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
        healthBar.value = 1;
    }
    
    // Update is called once per frame
    void Update()
    {
        health = healthBar.value;
        if (health <= 0f)
        {
            alive = false;
        }
        if (alive == true)
        {
            //move input
            // move = new Vector3(Input.GetAxisRaw("Horizontal"),0f, Input.GetAxisRaw("Vertical"));
            move = new Vector3(Input.GetAxisRaw("Horizontal"),0f, 0f);

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
        else
        {
            move = new Vector3(0f,0f, 0f);
            FindObjectOfType<GameController>().EndGame();
        }
        animator.SetFloat("Move", Mathf.Abs(Input.GetAxisRaw("Horizontal")));
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
           
           if(move != Vector3.zero)
        {
            transform.forward = move;
        }
    }
    
    void OnCollisionStay()
    {
        grounded = true;
    }

}
