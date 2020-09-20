using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getName : MonoBehaviour
{
     public Text placeName;

void Start(){
    placeName.text = mynameis.Instance.asd;
}
     void Update(){
        placeName.text = mynameis.Instance.asd;
     }
}
