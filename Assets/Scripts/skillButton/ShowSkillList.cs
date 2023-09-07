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

    SkillListViewer SkillListViewerSc;

    // Start is called before the first frame update
    void Start()
    {
        SkillListViewerSc = FindObjectOfType<SkillListViewer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowListUI()
    {
        ListUI.SetActive(true);
        button.SetActive(false);

        SkillListViewerSc.ListViewer();
    }

    public void CloseListUI()
    {
        ListUI.SetActive(false);
        button.SetActive(true);
    }
}
