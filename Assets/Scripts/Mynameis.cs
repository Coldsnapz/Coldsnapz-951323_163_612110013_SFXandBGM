using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Mynameis : Singleton<Mynameis>
{
    protected Mynameis() { }
    public string ClassName{get;} ="Mynameis";
    public string playername {get; set;} = "<name is not exist!>";
}
