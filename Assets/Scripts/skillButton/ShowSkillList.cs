using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowSkillList : MonoBehaviour
{
    [SerializeField]
    GameObject ListUI;

    [SerializeField]
    GameObject button;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowListUI()
    {
        ListUI.SetActive(true);
        button.SetActive(false);
    }
}
