using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    public string myName;
    void Start()
    {
        myName = Mynameis.Instance.playername;
        Debug.Log(myName);
    }

    // Update is called once per frame
}
