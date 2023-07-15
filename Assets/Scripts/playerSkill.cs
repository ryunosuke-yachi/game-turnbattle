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
        enemyStatus.HP -= damage;//enemyのHPを10～11減少させる
        Debug.Log("Enemyに" + damage + "のダメージ");
        playerskillData.skillInfoList[0].isSelect = false;
    }

    public void secondAttack()
    {
        int[] damage = new int[2];
        Debug.Log(playerskillData.skillInfoList[1].Name);
        for (int i = 0; i < 2; ++i)
        {
            damage[i] = Random.Range(10, 11);//enemyのHPを10～11減少させる
            enemyStatus.HP -= damage[i];
            Debug.Log("Enemyに" + damage[i] + "のダメージ");
        }
        playerskillData.skillInfoList[1].isSelect = false;
    }

    public void thirdAttack()
    {
        int damage = Random.Range(44, 45);
        Debug.Log(playerskillData.skillInfoList[2].Name);
        enemyStatus.HP -= damage;//enemyのHPを44～45減少させる
        Debug.Log("Enemyに" + damage + "のダメージ");
        playerskillData.skillInfoList[2].isSelect = false;
    }

    public void fourthAttack()
    {
        int damage = Random.Range(66, 67);
        Debug.Log(playerskillData.skillInfoList[3].Name);
        enemyStatus.HP -= damage;//enemyのHPを66～67減少させる
        Debug.Log("Enemyに" + damage + "のダメージ");
        playerskillData.skillInfoList[3].isSelect = false;
    }

    public void fifthAttack()
    {
        int damage = Random.Range(40, 50);
        Debug.Log(playerskillData.skillInfoList[4].Name);
        enemyStatus.HP -= damage;//enemyのHPを40～50減少させる
        Debug.Log("Enemyに" + damage + "のダメージ");
        playerStatus.HP += damage / 2;
        Debug.Log("Playerを" + damage/2 + "回復");
        playerskillData.skillInfoList[4].isSelect = false;
    }

    public void firstDefense()
    {
        Debug.Log(playerskillData.skillInfoList[5].Name);
        playerskillData.skillInfoList[5].isUsed = true;
        Debug.Log("次に受けるダメージが50%減少");
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
