using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject target;
    public float moveSpeed;
    private Vector3 targetPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        targetPos = new Vector3 (target.transform.position.x,3f,target.transform.position.z - 4f);
        transform.position = Vector3.Lerp (transform.position,targetPos,moveSpeed * Time.deltaTime);
    }
}
