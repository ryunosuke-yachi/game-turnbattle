using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class EnemyStatus : ScriptableObject
{

    public int HP;//敵のHP
    public int MP;//敵のMP
    public int gauge;//敵のゲージ状況
    public List<int> diceList;
    public int diceSituation;//どのダイスをふるか
    public int increaseGauge = 20;//一回の行動で増えるゲージの量
    public int maxGauge = 100;//ゲージのmax量
    public bool isDead;
    public int currentSkill; //どのスキルを使うかの番号
}
