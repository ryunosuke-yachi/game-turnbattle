using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtkCon : MonoBehaviour
{
    private bool atkBoolFlag = false;

    [SerializeField] private GameObject atkP;
    private GameObject atkPInstantiate;

    public bool AtkBoolFlag
    {
        get
        {
            return this.atkBoolFlag;
        }
        set
        {
            this.atkBoolFlag = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void atkButton()
    {
        atkPInstantiate = GameObject.Instantiate(atkP) as GameObject;
        atkBoolFlag = true;
    }
}
