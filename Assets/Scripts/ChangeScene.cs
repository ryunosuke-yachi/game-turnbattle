using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{

    Initialize initializeSc;
    // Start is called before the first frame update
    void Start()
    {
        initializeSc = gameObject.GetComponent<Initialize>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            initializeSc.InitializeStatus();
            SceneManager.LoadScene("MainGame");
        }
    }
}
