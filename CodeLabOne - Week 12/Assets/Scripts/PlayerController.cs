using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //any time you're directly using physics, use fixed update.

    [SerializeField] //serializefield lets you see the variable in the inspector. 
    private float moveSpeed = 2.0f;

    Vector3 getInput;

    private void Update()
    {        
        getInput = new Vector3(Input.GetAxis("Horizontal"), 0,  Input.GetAxis("Vertical"));
    }

    private void FixedUpdate()
    {
        GetComponent<Rigidbody>().velocity = getInput * moveSpeed;

        Vector3 lookPos = new Vector3(
                transform.position.x + GetComponent<Rigidbody>().velocity.x,
                transform.position.y,
                transform.position.z + GetComponent<Rigidbody>().velocity.z
            );
        transform.LookAt(lookPos); //orients the forward face of the object (the z line) towards whatever vector you specify. 
    }

}
