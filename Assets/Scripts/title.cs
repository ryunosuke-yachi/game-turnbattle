using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class title : MonoBehaviour
{
    public Image startText;
    Color color;
    float time;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        color.a = Mathf.Cos(2 * time) / 2 + 0.5f;
        Debug.Log(color.a);
        startText.color = new Color(1, 1, 1, color.a);
        
    }
}
