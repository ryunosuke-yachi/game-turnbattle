using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    bool sw;
    public void Push()
    {
        sw = true;
    }
    public void noPush()
    {
        sw = false;
    }

    void Update()
    {
        if (sw)
        {
            Debug.Log("Push");
        }
    }
}
