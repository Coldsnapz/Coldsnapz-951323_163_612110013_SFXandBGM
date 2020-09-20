using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A)){
            Rigidbody rb = this.GetComponent<Rigidbody>();
            rb.AddForce(new Vector3(-3f,0,0));
        }
        if (Input.GetKey(KeyCode.D)){
            Rigidbody rb = this.GetComponent<Rigidbody>();
            rb.AddForce(new Vector3(3f,0,0));
        }
        if (Input.GetKey(KeyCode.W)){
            Rigidbody rb = this.GetComponent<Rigidbody>();
            rb.AddForce(new Vector3(0,0,3f));
        }
        if (Input.GetKey(KeyCode.S)){
            Rigidbody rb = this.GetComponent<Rigidbody>();
            rb.AddForce(new Vector3(0,0,-3f));
        }
    }
}
