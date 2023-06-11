using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skillCon : MonoBehaviour
{
    //Ši”[‚·‚é—p‚ÌList
    public List<skill> buttonList = new List<skill>();

    public void Start()
    {
        buttonList = new List<skill>();
    }

    public void AddToList(int skNum, string skName)
    {
        skill newElemet = new skill(skNum, skName);
        buttonList.Add(newElemet);
    }

    public void RemoveFromList(int skNum, string skName)
    {
        skill elementToRemove = buttonList.Find(skill => skill.skNum == skNum && skill.skName == skName);
        if (elementToRemove != null)
        {
            buttonList.Remove(elementToRemove);
        }
    }

    public void DisplayList()
    {
        foreach(skill element in buttonList)
        {
            Debug.Log(element.skNum + element.skName);
        }
    }
}
