using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class EnemyStatus : ScriptableObject
{

    public int HP;//敵のHP
    public int MP;//敵のMP
    public int gauge;//敵のゲージ状況
    public int[] damage = new int [2];//敵が与えるダメージ
    public int [] diceNum = new int [5];//ダイスの個数
    public int diceSituation;//どのダイスをふるか
    public int increaseGauge = 20;//一回の行動で増えるゲージの量
    public int maxGauge = 100;//ゲージのmax量
}
