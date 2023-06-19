using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Re : MonoBehaviour
{
    private bool reBoolFlag = false;
    
    [SerializeField] private GameObject thisPre;
    [SerializeField] private GameObject mainCan;
    private GameObject mainPreInstantiate;

    public bool ReBoolFlag
    {
        get
        {
            return this.reBoolFlag;
        }
        set
        {
            this.reBoolFlag = value;
        }
    }

    public void ReButton()
    {
        mainPreInstantiate = GameObject.Instantiate(mainCan) as GameObject;
        reBoolFlag = true;
        Destroy(thisPre);
    }
}
