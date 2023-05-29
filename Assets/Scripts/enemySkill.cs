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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void useEnemySkill() {
        
        if(enemyStatus.MP <= enemyskillData.enemySkillInfoList[0].maxMP && enemyStatus.gauge < enemyStatus.maxGauge) { 
            singleAttack();
            Debug.Log(enemyskillData.enemySkillInfoList[0].name);
        }else if(enemyStatus.MP <= enemyskillData.enemySkillInfoList[1].maxMP && enemyStatus.gauge < enemyStatus.maxGauge) {
            doubleAttack();
            Debug.Log(enemyskillData.enemySkillInfoList[1].name);
        }
        
    }

    public void singleAttack() {
        int damage = Random.Range(10,15);
        playerStatus.HP -= damage;//playerのHPを10～11減少させる
        Debug.Log("Playerに" + damage +"のダメージ");
        enemyStatus.gauge += enemyStatus.increaseGauge;
        Debug.Log("ゲージ:" + enemyStatus.gauge);
    }

    public void doubleAttack() {
        int[] damage = new int [2];
        for(int i = 0;i < 2; ++i) {
            damage[i] = Random.Range(10,15);//playerのHPを10～11減少させる
            playerStatus.HP -=damage[i];
            Debug.Log("Playerに" + damage[i] + "のダメージ");
        }
        enemyStatus.gauge += enemyStatus.increaseGauge;
        Debug.Log("ゲージ:" + enemyStatus.gauge);

    }
}
