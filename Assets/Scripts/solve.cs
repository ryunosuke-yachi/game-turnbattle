using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class solve : MonoBehaviour
{
    [SerializeField]
    skillData playerSkillData;
    [SerializeField]
    PlayerStatus playerStatus;
    [SerializeField]
    EnemyStatus enemyStatus;
    [SerializeField]
    GameObject animator;
    TriggerAnimation TriggerAnimationSc;
    skillCon skillConSc;
    skillSel skillSelSc;
    playerSkill playerSkillSc;
    enemySkill enemySkillSc;
    switchUI switchUISc;
    ChangeScene1 ChangeScene1Sc;
    private bool usedCoroutine = false;
    public GameObject PlayerMP;
    PlayerStatusUIManager PlayerStatusUIManagerSc;

    public int turnCount;
    public GameObject skillObject;

    private void Start()
    {
        TriggerAnimationSc = animator.GetComponent<TriggerAnimation>();
    }
    public void solveTurn()
    {
        skillSelSc = FindObjectOfType<skillSel>();
        skillConSc = skillObject.GetComponent<skillCon>();
        enemySkillSc = GetComponent<enemySkill>();
        switchUISc = GetComponent<switchUI>();
        playerSkillSc = GetComponent<playerSkill>();
        ChangeScene1Sc = GetComponent<ChangeScene1>();
        PlayerStatusUIManagerSc = PlayerMP.GetComponent<PlayerStatusUIManager>();
        enemySkillSc.currentSkill();
        Debug.Log("skillconut:" + skillConSc.buttonList.Count);
        usedCoroutine = true;
        StartCoroutine(SkillSolve());


        //skillSelSc.setInitialValues();

    }




    IEnumerator SkillSolve()
    {

            for (int i = 0; i < skillConSc.buttonList.Count; i++)
            {
                Debug.Log("test3");
                switch (skillConSc.buttonList[i])
                {
                    case 0:
                        TriggerAnimationSc.TriggerPlayerAnimation("singleAttack");
                        playerSkillSc.firstAttack();
                        break;
                    case 1:
                        playerSkillSc.secondAttack();
                        TriggerAnimationSc.TriggerPlayerAnimation("doubleAttack");
                        break;
                    case 2:
                        playerSkillSc.thirdAttack();
                        TriggerAnimationSc.TriggerPlayerAnimation("thirdAttack");
                        break;
                    case 3:
                        playerSkillSc.fourthAttack();
                        TriggerAnimationSc.TriggerPlayerAnimation("fourthAttack");
                        break;
                    case 4:
                        playerSkillSc.fifthAttack();
                        TriggerAnimationSc.TriggerPlayerAnimation("fifthAttack");
                        break;
                    case 5:
                        playerSkillSc.firstDefense();
                        TriggerAnimationSc.TriggerPlayerAnimation("guard");
                        break;
                    case 6:
                        playerSkillSc.firstItem();
                        TriggerAnimationSc.TriggerPlayerAnimation("diceSkill");
                        break;
                    case 7:
                        playerSkillSc.secondItem();
                        TriggerAnimationSc.TriggerPlayerAnimation("diceSkill");
                        break;
                }
                while (TriggerAnimationSc.playerAnimationPlaying)
                {
                   
                    yield return null;
                }
            }

            enemySkillSc.useEnemySkill(); //“G‚Ìs“®ˆ—

            playerStatus.MP = 0;
            playerStatus.MaxMP = 0;
            enemyStatus.MP = 0;
            //playerStatus.diceSituation = 0;
            //enemyStatus.diceSituation = 0;
            skillConSc.buttonList.Clear();

            for (int skillNum = 5; skillNum < 8; skillNum++)
            {
                if (playerSkillData.skillInfoList[skillNum].turnLimit != 0)
                {
                    playerSkillData.skillInfoList[skillNum].turnLimit -= 1;
                }
            }

            Debug.Log(playerStatus.HP);
            Debug.Log(enemyStatus.HP);
            switchUISc.displayDice();
            PlayerStatusUIManagerSc.CalculateMPRatio();
            PlayerStatusUIManagerSc.CalculateMPRatio();
            usedCoroutine = false;
            yield return null;
    }
}
