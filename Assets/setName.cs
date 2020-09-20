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
            mynameis.Instance.asd = whereToGetNameFrom.text;
        }
        else if (whereToGetNameFrom == null)
        {
            mynameis.Instance.asd = mynameis.Instance.asd;
        }
    }
}
