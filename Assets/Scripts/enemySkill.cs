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
    playerSkill playerSkillSc;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void useEnemySkill() {
        switch (enemyStatus.currentSkill)
        {
            case 0:
                singleAttack();
                break;
            case 1:
                doubleAttack();
                break;
            case 2:
                thirdAttack();
                break;
            case 3:
                fourthAttack();
                break;
            case 4:
                ult();
                break;
        }
        
    }

    public void currentSkill()
    {
        if (enemyStatus.gauge == enemyStatus.maxGauge)
        {
            enemyStatus.currentSkill = 4;
        }
        else if (enemyStatus.MP <= enemyskillData.enemySkillInfoList[0].maxMP && enemyStatus.gauge < enemyStatus.maxGauge)
        {
            enemyStatus.currentSkill = 0;
        }
        else if (enemyStatus.MP <= enemyskillData.enemySkillInfoList[1].maxMP && enemyStatus.gauge < enemyStatus.maxGauge)
        {
            enemyStatus.currentSkill = 1;
        }
        else if (enemyStatus.MP <= enemyskillData.enemySkillInfoList[2].maxMP && enemyStatus.gauge < enemyStatus.maxGauge)
        {
            enemyStatus.currentSkill = 2;
        }
        else if (enemyStatus.MP <= enemyskillData.enemySkillInfoList[3].maxMP && enemyStatus.gauge < enemyStatus.maxGauge)
        {
            enemyStatus.currentSkill = 3;
        }
    }
    public void singleAttack() {
        int damage = Random.Range(10,15);
        if (playerskillData.skillInfoList[5].isUsed == true)
        {
            damage /= 2;
        }
        playerStatus.HP -= damage;//player��HP��10�`11����������
        Debug.Log("Player��" + damage +"�̃_���[�W");
        enemyStatus.gauge += enemyStatus.increaseGauge;
        Debug.Log("�Q�[�W:" + enemyStatus.gauge);
    }

    public void doubleAttack() {
        int[] damage = new int [2];
        for(int i = 0;i < 2; ++i) {
            if (playerskillData.skillInfoList[5].isUsed == true)
            {
                damage [0] /= 2;
            }
            damage[i] = Random.Range(10,15);//player��HP��10�`11����������
            playerStatus.HP -=damage[i];
            Debug.Log("Player��" + damage[i] + "�̃_���[�W");
        }
        enemyStatus.gauge += enemyStatus.increaseGauge;
        Debug.Log("�Q�[�W:" + enemyStatus.gauge);

    }

    public void thirdAttack()
    {
        int damage = Random.Range(50,56);
        if (playerskillData.skillInfoList[5].isUsed == true)
        {
            damage /= 2;
        }
        playerStatus.HP -= damage;
        Debug.Log("Player��" + damage + "�̃_���[�W");
        enemyStatus.gauge += enemyStatus.increaseGauge;
        Debug.Log("�Q�[�W" + enemyStatus.gauge);
    }

    public void fourthAttack()
    {
        int damage = Random.Range(86,89);
        if (playerskillData.skillInfoList[5].isUsed == true)
        {
            damage /= 2;
        }
        playerStatus.HP -= damage;
        Debug.Log("Player��" + damage + "�̃_���[�W");
        enemyStatus.gauge += enemyStatus.increaseGauge;
        Debug.Log("�Q�[�W�F" + enemyStatus.gauge);
    }

    public void ult()
    {
        int damage = 150;
        if (playerskillData.skillInfoList[5].isUsed == true)
        {
            damage /= 2;
        }
        playerStatus.HP -= damage;
        Debug.Log("�v���C���[��" + damage + "�̃_���[�W");
        enemyStatus.gauge = 0;
        Debug.Log("�Q�[�W�F" + enemyStatus.gauge);
    }
}
