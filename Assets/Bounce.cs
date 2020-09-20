using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Impact") {
            Rigidbody rb = this.GetComponent<Rigidbody>();
            rb.AddForce(new Vector3(0,100,0),ForceMode.Impulse);
        }
    }
}
