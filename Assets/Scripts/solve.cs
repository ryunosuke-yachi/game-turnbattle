using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class solve : MonoBehaviour
{
    [SerializeField]
    skillData playerSkillData;
    [SerializeField]
    PlayerStatus playerStatus;
    [SerializeField]
    EnemyStatus enemyStatus;

    skillCon skillConSc;
    skillSel skillSelSc;
    playerSkill playerSkillSc;
    enemySkill enemySkillSc;
    switchUI switchUISc;
    ChangeScene1 ChangeScene1Sc;

    public int turnCount;
    public GameObject skillObject;

    public void solveTurn()
    {
        skillSelSc = FindObjectOfType<skillSel>();
        skillConSc = skillObject.GetComponent<skillCon>();
        enemySkillSc = GetComponent<enemySkill>();
        switchUISc = GetComponent<switchUI>();
        playerSkillSc = GetComponent<playerSkill>();
        ChangeScene1Sc = GetComponent<ChangeScene1>();

        Debug.Log("skillconut:" + skillConSc.buttonList.Count);
        for(int i = 0; i < skillConSc.buttonList.Count; i++) //Player‚Ìs“®ˆ—
        {
            switch (skillConSc.buttonList[i])
            {
                case 0:
                    playerSkillSc.firstAttack();
                    break;
                case 1:
                    playerSkillSc.secondAttack();
                    break;
                case 2:
                    playerSkillSc.thirdAttack();
                    break;
                case 3:
                    playerSkillSc.fourthAttack();
                    break;
                case 4:
                    playerSkillSc.fifthAttack();
                    break;
                case 5:
                    playerSkillSc.firstDefense();
                    break;
                case 6:
                    playerSkillSc.firstItem();
                    break;
                case 7:
                    playerSkillSc.secondItem();
                    break;
            }
        }
        enemySkillSc.useEnemySkill(); //“G‚Ìs“®ˆ—

        playerStatus.MP = 0;
        enemyStatus.MP = 0;
        playerStatus.diceSituation = 0;
        enemyStatus.diceSituation = 0;
        skillConSc.buttonList.Clear();

        for(int i = 5; i < 8; i++)
        {
            if(playerSkillData.skillInfoList[i].turnLimit != 0)
            {
                playerSkillData.skillInfoList[i].turnLimit -= 1;
            }
        }

        Debug.Log(playerStatus.HP);
        Debug.Log(enemyStatus.HP);

        //skillSelSc.setInitialValues();
        //skillSelSc.usedFunction = false;
        switchUISc.displayDice();
    }
}
