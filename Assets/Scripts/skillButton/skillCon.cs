using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skillCon : MonoBehaviour
{
    //�i�[����p��List
    public List<int> buttonList = new List<int>();

    public void Start()
    {
        
    }

    public void AddToList(int element)
    {
        buttonList.Add(element);
    }

    public void RemoveFromList(int element)
    {
        buttonList.Remove(element);
    }
}
