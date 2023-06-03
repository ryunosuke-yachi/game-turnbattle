using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemCon : MonoBehaviour
{
    private bool itemBoolFlag = false;

    [SerializeField] private GameObject itemP;
    [SerializeField] private GameObject mainCan;
    private GameObject itemPInstantiate;

    public bool ItemBoolFlag
    {
        get
        {
            return this.itemBoolFlag;
        }
        set
        {
            this.itemBoolFlag = value;
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void itemButton()
    {
        itemPInstantiate = GameObject.Instantiate(itemP) as GameObject;
        itemBoolFlag = true;
        mainCan.SetActive(false);
    }
}
