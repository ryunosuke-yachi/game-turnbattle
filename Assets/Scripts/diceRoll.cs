using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diceRoll : MonoBehaviour
{
    const int diceNum = 5;
    [SerializeField]
    const int min = 1;
    [SerializeField]
    const int max = 7;
    public int[] dice = new int[5];

    public int mp;
    // Start is called before the first frame update
    void Start()
    {
        mp = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DiceRolling() {
        Debug.Log("ダイスを振ります");

        for(int i = 0;i < diceNum;i++)
        {
            dice[i] = Random.Range(min, max);
        }
        Debug.Log(dice[0]);
        Debug.Log(dice[1]);
        Debug.Log(dice[2]);
        Debug.Log(dice[3]);
        Debug.Log(dice[4]);
        mp = Sum(dice[0],dice[1],dice[2],dice[3],dice[4]);
        Debug.Log("合計" + mp);
    }

    public int Sum(int dice1,int dice2,int dice3,int dice4,int dice5) {
        return dice1 + dice2 + dice3 + dice4 + dice5;
        
    }
}
