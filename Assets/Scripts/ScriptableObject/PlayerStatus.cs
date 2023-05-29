using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PlayerStatus : ScriptableObject
{
    public int MP;
    public int HP;
    public int diceSituation;
    public int[] diceNum = new int[5];
    public bool isDead;
}
