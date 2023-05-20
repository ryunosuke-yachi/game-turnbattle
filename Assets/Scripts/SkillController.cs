using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillController : MonoBehaviour
{
    public bool sw;

    // Start is called before the first frame update
    void Start()
    {
        sw = false;
    }

    void Update()
    {
        if(sw == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("onLeft");
                sw = true;
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                Debug.Log("offLeft");
                sw = false;
            }
        }
    }
}
