using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.UI;

public class diceSkipButton : MonoBehaviour
{
    [SerializeField] private GameObject[] targetObject;
    private dice[] diceSc;
    // Start is called before the first frame update
    void Start()
    {
        Button button = GetComponent<Button>();
        button.onClick.AddListener(HandleButtonClick);
        for(int i = 0;i < targetObject.Length;i++)
        {
            diceSc[i] = targetObject[i].GetComponent<dice>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public  void HandleButtonClick()
    {
        for(int i = 0;i < targetObject.Length;i++)
        {
            if (targetObject[i].activeSelf)
            {
                diceSc[i].skip();
            }
        }
    }

}
