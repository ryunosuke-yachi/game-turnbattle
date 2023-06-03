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
        int damage = Random.Range(10,15);
        if(playerskillData.skillInfoList[5].inEffect)
        {
            damage/= 2;
            playerskillData.skillInfoList[5].inEffect = false;
        }
        playerStatus.HP -= damage;//playerのHPを10～11減少させる
        Debug.Log("Playerに" + damage +"のダメージ");
        enemyStatus.gauge += enemyStatus.increaseGauge;
        Debug.Log("ゲージ:" + enemyStatus.gauge);
    }

    public void doubleAttack() {
        int[] damage = new int [2];
        for(int i = 0;i < 2; ++i) {
            damage[i] = Random.Range(10,15);//playerのHPを10～11減少させる
            if (playerskillData.skillInfoList[5].inEffect)
            {
                damage[i] /= 2;
                playerskillData.skillInfoList[5].inEffect = false;
            }
            playerStatus.HP -=damage[i];
            Debug.Log("Playerに" + damage[i] + "のダメージ");
        }
        enemyStatus.gauge += enemyStatus.increaseGauge;
        Debug.Log("ゲージ:" + enemyStatus.gauge);

    }

    public void thirdAttack()
    {
        int damage = Random.Range(50,56);
        if (playerskillData.skillInfoList[5].inEffect)
        {
            damage /= 2;
            playerskillData.skillInfoList[5].inEffect = false;
        }
        playerStatus.HP -= damage;
        Debug.Log("Playerに" + damage + "のダメージ");
        enemyStatus.gauge += enemyStatus.increaseGauge;
        Debug.Log("ゲージ" + enemyStatus.gauge);
    }

    public void fourthAttack()
    {
        int damage = Random.Range(86,89);
        if (playerskillData.skillInfoList[5].inEffect)
        {
            damage /= 2;
            playerskillData.skillInfoList[5].inEffect = false;
        }
        playerStatus.HP -= damage;
        Debug.Log("Playerに" + damage + "のダメージ");
        enemyStatus.gauge += enemyStatus.increaseGauge;
        Debug.Log("ゲージ：" + enemyStatus.gauge);
    }

    public void ult()
    {
        int damage = 150;
        if (playerskillData.skillInfoList[5].inEffect)
        {
            damage /= 2;
            playerskillData.skillInfoList[5].inEffect = false;
        }
        playerStatus.HP -= damage;
        Debug.Log("プレイヤーに" + damage + "のダメージ");
        enemyStatus.gauge = 0;
        Debug.Log("ゲージ：" + enemyStatus.gauge);
    }
}
