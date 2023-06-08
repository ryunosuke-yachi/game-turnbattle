using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySkill : MonoBehaviour
{
    [SerializeField]
    EnemyStatus enemyStatus;
    [SerializeField]
    enemySkillData enemyskillData;
    [SerializeField]
    PlayerStatus playerStatus;
    [SerializeField]
    skillData playerskillData;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void useEnemySkill() {
        if(enemyStatus.gauge == enemyStatus.maxGauge)
        {
            ult();
            Debug.Log(enemyskillData.enemySkillInfoList[4].name);
        }
        else if(enemyStatus.MP <= enemyskillData.enemySkillInfoList[0].maxMP && enemyStatus.gauge < enemyStatus.maxGauge) { 
            singleAttack();
            Debug.Log(enemyskillData.enemySkillInfoList[0].name);
        }else if(enemyStatus.MP <= enemyskillData.enemySkillInfoList[1].maxMP && enemyStatus.gauge < enemyStatus.maxGauge) {
            doubleAttack();
            Debug.Log(enemyskillData.enemySkillInfoList[1].name);
        }else if (enemyStatus.MP <= enemyskillData.enemySkillInfoList[2].maxMP && enemyStatus.gauge < enemyStatus.maxGauge)
        {
            thirdAttack();
            Debug.Log(enemyskillData.enemySkillInfoList[2].name);
        }else if(enemyStatus.MP <= enemyskillData.enemySkillInfoList[3].maxMP && enemyStatus.gauge < enemyStatus.maxGauge)
        {
            fourthAttack();
            Debug.Log(enemyskillData.enemySkillInfoList[3].name);
        }
        
    }

    public void singleAttack() {
        enemyStatus.damage[0] = Random.Range(10,15);
        if(playerskillData.skillInfoList[5].inEffect)
        {
            enemyStatus.damage[0] /= 2;
            playerskillData.skillInfoList[5].inEffect = false;
        }
        playerStatus.HP -= enemyStatus.damage[0];//player��HP��10�`11����������
        Debug.Log("Player��" + enemyStatus.damage[0] +"�̃_���[�W");
        enemyStatus.gauge += enemyStatus.increaseGauge;
        Debug.Log("�Q�[�W:" + enemyStatus.gauge);
    }

    public void doubleAttack() {

        for(int i = 0;i < 2; ++i) {
            enemyStatus.damage[i] = Random.Range(10,15);//player��HP��10�`11����������
            if (playerskillData.skillInfoList[5].inEffect)
            {
                enemyStatus.damage[i] /= 2;
                playerskillData.skillInfoList[5].inEffect = false;
            }
            playerStatus.HP -=enemyStatus.damage[i];
            Debug.Log("Player��" + enemyStatus.damage[i] + "�̃_���[�W");
        }
        enemyStatus.gauge += enemyStatus.increaseGauge;
        Debug.Log("�Q�[�W:" + enemyStatus.gauge);

    }

    public void thirdAttack()
    {
        enemyStatus.damage[0] = Random.Range(50,56);
        if (playerskillData.skillInfoList[5].inEffect)
        {
            enemyStatus.damage[0] /= 2;
            playerskillData.skillInfoList[5].inEffect = false;
        }
        playerStatus.HP -= enemyStatus.damage[0];
        Debug.Log("Player��" + enemyStatus.damage[0] + "�̃_���[�W");
        enemyStatus.gauge += enemyStatus.increaseGauge;
        Debug.Log("�Q�[�W" + enemyStatus.gauge);
    }

    public void fourthAttack()
    {
        enemyStatus.damage[0] = Random.Range(86,89);
        if (playerskillData.skillInfoList[5].inEffect)
        {
            enemyStatus.damage[0] /= 2;
            playerskillData.skillInfoList[5].inEffect = false;
        }
        playerStatus.HP -= enemyStatus.damage[0];
        Debug.Log("Player��" + enemyStatus.damage[0] + "�̃_���[�W");
        enemyStatus.gauge += enemyStatus.increaseGauge;
        Debug.Log("�Q�[�W�F" + enemyStatus.gauge);
    }

    public void ult()
    {
        enemyStatus.damage[0] = enemyStatus.MP * 5;
        if (playerskillData.skillInfoList[5].inEffect)
        {
            enemyStatus.damage[0] /= 2;
            playerskillData.skillInfoList[5].inEffect = false;
        }
        playerStatus.HP -= enemyStatus.damage[0];
        Debug.Log("�v���C���[��" + enemyStatus.damage[0] + "�̃_���[�W");
        enemyStatus.gauge = 0;
        Debug.Log("�Q�[�W�F" + enemyStatus.gauge);
    }
}
