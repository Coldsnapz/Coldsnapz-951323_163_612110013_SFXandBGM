using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getName : MonoBehaviour
{
     public Text placeName;

void Start(){
    placeName.text = Mynameis.Instance.playername;
}
     void Update(){
        placeName.text = Mynameis.Instance.playername;
     }
}
