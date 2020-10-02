using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ForceControlOnObjectOnXZPlane : MonoBehaviour
{
    Rigidbody _rigidbody;
    [SerializeField]
    protected float _forceMagnitudec;

    // Start is called before the first frame update
    void Start()
    {
       _rigidbody = this.GetComponent <Rigidbody >(); 
    }

    // Update is called once per frame
    void Update()
    {
        UpdateInput();
    }

    void UpdateInput() {
        float hori = Input.GetAxis("Horizontal");
        float verti = -1 * Input.GetAxis("Vertical");

        Vector3 unitPositiveHori = new Vector3(0,0,1);
        Vector3 unitPositiveVerti = new Vector3(1, 0, 0);

        _rigidbody.AddForce(unitPositiveHori* hori*_forceMagnitudec ,ForceMode.Force);
        _rigidbody.AddForce(unitPositiveVerti * verti * _forceMagnitudec , ForceMode.Force);
    }
}
