using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class impactLauncher : MonoBehaviour
{
    public float _force;
    public float _mass = 1;

    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent <Rigidbody >();
        rb.mass = _mass;
    }

    // Update is called once per frame
    void Update()
    {
        rb = this.GetComponent <Rigidbody >();

        if (Input.GetKeyDown(KeyCode.A)){
            rb.AddForce(new Vector3(_force,0,0), ForceMode.Impulse);
        }
    }
}
