using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewClass : MonoBehaviour
{ //This is the dump of bad code
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

        // // Bad camera code
        // if (target == null)
        // {
        //     Debug.LogWarning("Missing target ref!", this);
        // }
        // if (offSetPositionSpace == Space.Self)
        // {
        //     transform.position = player.Transformpoint(offSetPosition);
        // }
        // else
        // {
        //     transform.position = player.position + offSetPosition;
        // }
        // if(lookAt)
        // {
        //     transform.LookAt(player);
        // }
        // else
        // {
        //     transform.rotation = player.rotation;
        // }
        
        // // found in unity docs under Space.Self
        // transform.Rotate(Vector3.up * moveSpeed *Time.deltaTime, Space.Self);
        
// if (Input.GetKeyDown(KeyCode.Mouse1))
// { 
//     GameObject instBullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
//     Rigidbody instRigidbody = instBullet.GetComponent<Rigidbody>();
//     instRigidbody.transform.position += transform.forward * (speed * Time.deltaTime);
//     
// }