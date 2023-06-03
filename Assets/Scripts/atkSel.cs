using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atkSel : MonoBehaviour
{
    //それぞれのボタンのフラグ
    private bool skill_1BoolFlag = false;
    private bool skill_2BoolFlag = false;
    private bool skill_3BoolFlag = false;
    private bool skill_4BoolFlag = false;
    private bool skill_5BoolFlag = false;

    //スキル情報を持っているScriptableObject
    [SerializeField]
    skillData playerSkillData;
    public bool Skill_1BoolFlag
    {
        get { return this.skill_1BoolFlag; }
        set { this.skill_1BoolFlag = value; }
    }

    public bool Skill_2BoolFlag
    {
        get { return this.skill_2BoolFlag; }
        set { this.skill_2BoolFlag = value; }
    }

    public bool Skill_3BoolFlag
    {
        get { return this.skill_3BoolFlag; }
        set { this.skill_3BoolFlag = value; }
    }

    public bool Skill_4BoolFlag
    {
        get { return this.skill_4BoolFlag; }
        set { this.skill_4BoolFlag = value; }
    }

    public bool Skill_5BoolFlag
    {
        get { return this.skill_5BoolFlag; }
        set { this.skill_5BoolFlag = value; }
    }

    //それぞれのボタンが押されたときのフラグの切り替え
    public void SelButton_1()
    {
        playerSkillData.skillInfoList[0].isSelect = true;
        skill_1BoolFlag = true;
        Debug.Log(playerSkillData.skillInfoList[0].Name);
    }

    public void SelButton_2()
    {
        playerSkillData.skillInfoList[1].isSelect = true;
        skill_2BoolFlag = true;
        Debug.Log(playerSkillData.skillInfoList[1].Name);
    }

    public void SelButton_3()
    {
        playerSkillData.skillInfoList[2].isSelect = true;
        skill_3BoolFlag = true;
        Debug.Log(playerSkillData.skillInfoList[2].Name);
    }

    public void SelButton_4()
    {
        playerSkillData.skillInfoList[3].isSelect = true;
        skill_4BoolFlag = true;
        Debug.Log(playerSkillData.skillInfoList[3].Name);
    }

    public void SelButton_5()
    {
        playerSkillData.skillInfoList[4].isSelect = true;
        skill_5BoolFlag = true;
        Debug.Log(playerSkillData.skillInfoList[4].Name);
    }
}
