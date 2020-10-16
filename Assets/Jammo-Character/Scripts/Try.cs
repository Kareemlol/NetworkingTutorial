using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Try : MonoBehaviour {
    private Rigidbody rb;
    public int baseSpeed;
    public int sprint;
    private int currentSpeed;
 
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update ()
    {
        //this makes the player go where the camera is pointing
        transform.position = transform.position + Camera.main.transform.forward*currentSpeed*Time.deltaTime;
 
        //this makes the player sprint when the shift key is pressed
        if (Input.GetKey(KeyCode.LeftShift))
        {
            currentSpeed = baseSpeed + sprint;
        }
        else
        {
            currentSpeed = baseSpeed;
        }
    }
}
