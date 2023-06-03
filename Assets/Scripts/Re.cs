using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Re : MonoBehaviour
{
    [SerializeField] GameObject thisPre;
    [SerializeField] GameObject mainCan;

    private void Start()
    {
        
    }

    public void Update()
    {
       
    }

    public void OnClick()
    {
        Destroy(thisPre);
        mainCan.SetActive(true);
    }
}
