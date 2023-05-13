using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnClick()
    {
        GameObject obj = GameObject.Find("Item");
        GameObject obj_1 = GameObject.Find("Defence");
        GameObject obj_2 = GameObject.Find("Attack");

        obj.SetActive(false);
        obj_1.SetActive(false);
        obj_2.SetActive(false);
    }
}
