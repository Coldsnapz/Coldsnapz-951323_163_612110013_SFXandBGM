using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class mynameis : Singleton<mynameis>
{
    protected mynameis() { }
    public string asd {get;set;} = "<name is not exist!>";
    void Start(){
        DontDestroyOnLoad(this.gameObject);
    }
}
