using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    [SerializeField]
    public Animator charaAnim;
    [SerializeField]
    public Animator cameraAnim;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            charaAnim.SetBool("start",true);
            cameraAnim.SetBool("start",true);
        }else
        {
            charaAnim.SetBool("start",false);
            cameraAnim.SetBool("start",false);
        }
    }
}
