using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setName : MonoBehaviour
{
    public Text whereToGetNameFrom;
    
    public void Update()
    {
        if (whereToGetNameFrom.text != "")
        {
            Mynameis.Instance.playername = whereToGetNameFrom.text;
        }
        else if (whereToGetNameFrom == null)
        {
            Mynameis.Instance.playername = Mynameis.Instance.playername;
        }
    }
}
