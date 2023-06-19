using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefCon : MonoBehaviour
{
    private bool defBoolFlag = false;

    [SerializeField] private GameObject defP;
    [SerializeField] private GameObject mainCan;
    private GameObject defPInstantiate;

    public bool DefBoolFlag
    {
        get
        {
            return this.defBoolFlag;
        }
        set
        {
            this.defBoolFlag = value;
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

    public void defButton()
    {
        defPInstantiate = GameObject.Instantiate(defP) as GameObject;
        defBoolFlag = true;
        Destroy(mainCan);
    }
}
