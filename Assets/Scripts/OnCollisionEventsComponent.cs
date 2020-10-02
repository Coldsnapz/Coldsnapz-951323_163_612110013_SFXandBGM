using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollisionEventsComponent : MonoBehaviour , IHasOriginalColour
{
    Color _originalColour;
    // Start is called before the first frame update
    void Start()
    {
        _originalColour = this.GetComponent <MeshRenderer >().materials[0].color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Color GetOriginalColour(){
        return this._originalColour;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rb =this.GetComponent <Rigidbody>();
        rb.AddForce(Random.Range(-1,1),500,0);
        rb.useGravity = true;
        this.GetComponent <MeshRenderer >().materials[0].color = Color.black;
    }

    private void OnCollisionStay(Collision collision)
    {
        this.GetComponent <MeshRenderer >().materials[0].color = Color.white;
    }
    private void OnCollisionExit(Collision collision)
    {
        Rigidbody rb =this.GetComponent <Rigidbody>();
        rb.AddForce(0,250,0);
        this.GetComponent <MeshRenderer >().materials[0].color = _originalColour;
    }
}
