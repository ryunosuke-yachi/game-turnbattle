using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class EnemyStatus : ScriptableObject
{

    public int HP;
    public int MP;
    public int gauge;
    public int [] diceNum = new int [5];
    public int diceSituation;
}
