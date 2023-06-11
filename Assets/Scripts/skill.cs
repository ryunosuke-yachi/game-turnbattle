using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skill : MonoBehaviour
{
    public int skNum;
    public string skName;

    public skill(int skNum, string skName)
    {
        this.skNum = skNum;
        this.skName = skName;
    }
}
