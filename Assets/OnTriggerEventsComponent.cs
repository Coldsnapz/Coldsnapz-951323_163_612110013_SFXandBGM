using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTriggerEventsComponent : MonoBehaviour , IHasOriginalColour
{
    Color _originalColour;
    float R; float G; float B;
    bool negative;

    // Start is called before the first frame update
    void Start()
    {
        _originalColour = this.GetComponent <MeshRenderer >().materials[0].color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Color GetOriginalColour()
    {
        return this._originalColour;
    }

    private void OnTriggerEnter(Collider collider)
    {
        this.GetComponent <MeshRenderer >().materials[0].color = _originalColour;
        R = _originalColour.r;
        G = _originalColour.g;
        B = _originalColour.b;
    }

    private void OnTriggerStay(Collider collider)
    {
        if (R < 1 && negative == false){
        R += Time.deltaTime/2;
        Debug.Log(R.ToString());
        }
        else if (G < 1 && negative == false){
        G += Time.deltaTime/2;
        Debug.Log(R.ToString());
        }
        else if (B < 1 && negative == false){
        B += Time.deltaTime/2;
        Debug.Log(R.ToString());
        }
        else if (negative == false)
        {
            negative = true;
        }
        else if (R > 0 && negative == true){
        R -= Time.deltaTime/2;
        Debug.Log(R.ToString());
        }
        else if (G > 0 && negative == true){
        G -= Time.deltaTime/2;
        Debug.Log(R.ToString());
        }
        else if (B > 0 && negative == true){
        B -= Time.deltaTime/2;
        Debug.Log(R.ToString());
        }
        else if (negative == true)
        {
            negative = false;
        }

        this.GetComponent <MeshRenderer >().materials[0].color = new Color(R,G,B);
    }

    private void OnTriggerExit(Collider collider)
    {
        
    }
}
