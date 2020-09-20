using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpherePlayerCollisionEvents : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Underground") {
            Rigidbody rb = this.gameObject.GetComponent <Rigidbody >();
            rb.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);
        } else if (other.gameObject.tag == "Item") {
            ItemBehaviour ib = other.gameObject.GetComponent <ItemBehaviour >();
            ib.PlayerCollided();
        }
    }
    void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Playground")
        {
            this.gameObject.GetComponent <MeshRenderer >().material.color = Color.red;
        }
    }
    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Playground")
        {
            this.gameObject.GetComponent <MeshRenderer >().material.color = Color.black;
        }
    }
}
