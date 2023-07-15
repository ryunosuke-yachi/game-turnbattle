using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSkill : MonoBehaviour
{
    [SerializeField]
    PlayerStatus playerStatus;
    [SerializeField]
    EnemyStatus enemyStatus;
    [SerializeField]
    skillData playerskillData;

    public void firstAttack()
    {
        Debug.Log(playerskillData.skillInfoList[0].Name);
        int damage = Random.Range(10, 11);
        enemyStatus.HP -= damage;//enemy��HP��10�`11����������
        Debug.Log("Enemy��" + damage + "�̃_���[�W");
        playerskillData.skillInfoList[0].isSelect = false;
    }

    public void secondAttack()
    {
        int[] damage = new int[2];
        Debug.Log(playerskillData.skillInfoList[1].Name);
        for (int i = 0; i < 2; ++i)
        {
            damage[i] = Random.Range(10, 11);//enemy��HP��10�`11����������
            enemyStatus.HP -= damage[i];
            Debug.Log("Enemy��" + damage[i] + "�̃_���[�W");
        }
        playerskillData.skillInfoList[1].isSelect = false;
    }

    public void thirdAttack()
    {
        int damage = Random.Range(44, 45);
        Debug.Log(playerskillData.skillInfoList[2].Name);
        enemyStatus.HP -= damage;//enemy��HP��44�`45����������
        Debug.Log("Enemy��" + damage + "�̃_���[�W");
        playerskillData.skillInfoList[2].isSelect = false;
    }

    public void fourthAttack()
    {
        int damage = Random.Range(66, 67);
        Debug.Log(playerskillData.skillInfoList[3].Name);
        enemyStatus.HP -= damage;//enemy��HP��66�`67����������
        Debug.Log("Enemy��" + damage + "�̃_���[�W");
        playerskillData.skillInfoList[3].isSelect = false;
    }

    public void fifthAttack()
    {
        int damage = Random.Range(40, 50);
        Debug.Log(playerskillData.skillInfoList[4].Name);
        enemyStatus.HP -= damage;//enemy��HP��40�`50����������
        Debug.Log("Enemy��" + damage + "�̃_���[�W");
        playerStatus.HP += damage / 2;
        Debug.Log("Player��" + damage/2 + "��");
        playerskillData.skillInfoList[4].isSelect = false;
    }

    public void firstDefense()
    {
        Debug.Log(playerskillData.skillInfoList[5].Name);
        playerskillData.skillInfoList[5].isUsed = true;
        Debug.Log("���Ɏ󂯂�_���[�W��50%����");
        playerskillData.skillInfoList[5].isSelect = false;
        playerskillData.skillInfoList[5].turnLimit = 3;
    }

    public void firstItem()
    {
        Debug.Log(playerskillData.skillInfoList[6].Name);
        playerStatus.diceSituation = 1;
        playerskillData.skillInfoList[6].isSelect = false;
        playerskillData.skillInfoList[6].turnLimit = 3;
    }

    public void secondItem()
    {
        Debug.Log(playerskillData.skillInfoList[7].Name);
        enemyStatus.diceSituation = 1;
        playerskillData.skillInfoList[7].isSelect = false;
        playerskillData.skillInfoList[7].turnLimit = 3;
    }
}
