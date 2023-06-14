using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class skillSel : MonoBehaviour
{
    private skillCon SkillCon;

    //スキル情報を持っているScriptableObject
    [SerializeField]
    skillData playerSkillData;

    [SerializeField]
    PlayerStatus PlayerStatus;

    public void Start()
    {
        SkillCon = FindObjectOfType<skillCon>();

        for (int i = 0; i < playerSkillData.skillInfoList.Count; i++)
        {
            playerSkillData.skillInfoList[i].isSelect = false;
        }
    }



    //それぞれのボタンが押されたときのフラグの切り替え
    public void SelButton_0()
    {

        if(playerSkillData.skillInfoList[0].isSelect == false)
        {
            playerSkillData.skillInfoList[0].isSelect = true;
            Debug.Log(playerSkillData.skillInfoList[0].Name);
            SkillCon.AddToList(0);
            PlayerStatus.MP -= playerSkillData.skillInfoList[0].MP;
            Debug.Log(PlayerStatus.MP);
        }
        else if(playerSkillData.skillInfoList[0].isSelect == true)
        {
            playerSkillData.skillInfoList[0].isSelect = false;
            SkillCon.RemoveFromList(0);
            PlayerStatus.MP += playerSkillData.skillInfoList[0].MP;
        }
        
    }

    public void SelButton_1()
    {
        if (playerSkillData.skillInfoList[1].isSelect == false)
        {
            playerSkillData.skillInfoList[1].isSelect = true;
            Debug.Log(playerSkillData.skillInfoList[1].Name);
            SkillCon.AddToList(1);
            PlayerStatus.MP -= playerSkillData.skillInfoList[1].MP;
        }
        else if (playerSkillData.skillInfoList[1].isSelect == true)
        {
            playerSkillData.skillInfoList[1].isSelect = false;
            SkillCon.RemoveFromList(1);
            PlayerStatus.MP += playerSkillData.skillInfoList[1].MP;
        }
    }

    public void SelButton_2()
    {
        if (playerSkillData.skillInfoList[2].isSelect == false)
        {
            playerSkillData.skillInfoList[2].isSelect = true;
            Debug.Log(playerSkillData.skillInfoList[2].Name);
            SkillCon.AddToList(2);
            PlayerStatus.MP -= playerSkillData.skillInfoList[2].MP;
        }
        else if (playerSkillData.skillInfoList[2].isSelect == true)
        {
            playerSkillData.skillInfoList[2].isSelect = false;
            SkillCon.RemoveFromList(2);
            PlayerStatus.MP += playerSkillData.skillInfoList[2].MP;
        }
    }

    public void SelButton_3()
    {
        if (playerSkillData.skillInfoList[3].isSelect == false)
        {
            playerSkillData.skillInfoList[3].isSelect = true;
            Debug.Log(playerSkillData.skillInfoList[3].Name);
            SkillCon.AddToList(3);
            PlayerStatus.MP -= playerSkillData.skillInfoList[3].MP;
        }
        else if (playerSkillData.skillInfoList[3].isSelect == true)
        {
            playerSkillData.skillInfoList[3].isSelect = false;
            SkillCon.RemoveFromList(3);
            PlayerStatus.MP += playerSkillData.skillInfoList[3].MP;
        }
    }

    public void SelButton_4()
    {
        if (playerSkillData.skillInfoList[4].isSelect == false)
        {
            playerSkillData.skillInfoList[4].isSelect = true;
            Debug.Log(playerSkillData.skillInfoList[4].Name);
            SkillCon.AddToList(4);
            PlayerStatus.MP -= playerSkillData.skillInfoList[4].MP;
        }
        else if (playerSkillData.skillInfoList[4].isSelect == true)
        {
            playerSkillData.skillInfoList[4].isSelect = false;
            SkillCon.RemoveFromList(4);
            PlayerStatus.MP += playerSkillData.skillInfoList[4].MP;
        }
    }

    public void SelButton_5()
    {
        if (playerSkillData.skillInfoList[5].isSelect == false)
        {
            playerSkillData.skillInfoList[5].isSelect = true;
            Debug.Log(playerSkillData.skillInfoList[5].Name);
            SkillCon.AddToList(5);
            PlayerStatus.MP -= playerSkillData.skillInfoList[5].MP;
        }
        else if (playerSkillData.skillInfoList[5].isSelect == true)
        {
            playerSkillData.skillInfoList[5].isSelect = false;
            SkillCon.RemoveFromList(5);
            PlayerStatus.MP += playerSkillData.skillInfoList[5].MP;
        }
    }

    public void SelButton_6()
    {
        if (playerSkillData.skillInfoList[6].isSelect == false)
        {
            playerSkillData.skillInfoList[6].isSelect = true;
            Debug.Log(playerSkillData.skillInfoList[6].Name);
            SkillCon.AddToList(6);
            PlayerStatus.MP -= playerSkillData.skillInfoList[6].MP;
        }
        else if (playerSkillData.skillInfoList[6].isSelect == true)
        {
            playerSkillData.skillInfoList[6].isSelect = false;
            SkillCon.RemoveFromList(6);
            PlayerStatus.MP += playerSkillData.skillInfoList[6].MP;
        }
    }

    public void SelButton_7()
    {
        if (playerSkillData.skillInfoList[7].isSelect == false)
        {
            playerSkillData.skillInfoList[7].isSelect = true;
            Debug.Log(playerSkillData.skillInfoList[7].Name);
            SkillCon.AddToList(7);
            PlayerStatus.MP -= playerSkillData.skillInfoList[7].MP;
        }
        else if (playerSkillData.skillInfoList[7].isSelect == true)
        {
            playerSkillData.skillInfoList[7].isSelect = false;
            SkillCon.RemoveFromList(7);
            PlayerStatus.MP += playerSkillData.skillInfoList[7].MP;
        }
    }
}
