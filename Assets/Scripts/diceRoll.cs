using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diceRoll : MonoBehaviour
{
    public int diceNum;
    public int diceNum2;
    public int diceNum3;
    public int diceNum4;
    public int diceNum5;
    public int result;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DiceRolling() {
        Debug.Log("ダイスを振ります");

        diceNum = Random.Range(1, 7);
        diceNum2 = Random.Range(1, 7);
        diceNum3 = Random.Range(1, 7);
        diceNum4 = Random.Range(1, 7);
        diceNum5 = Random.Range(1, 7);
        result = Sum(diceNum,diceNum2, diceNum3, diceNum4, diceNum5);
        Debug.Log(diceNum);
        Debug.Log(diceNum2);
        Debug.Log(diceNum3);
        Debug.Log(diceNum4);
        Debug.Log(diceNum5);
        Debug.Log("合計" + result);
    }

    public int Sum(int dice1,int dice2,int dice3,int dice4,int dice5) {
        return dice1+dice2+dice3+dice4+dice5;
    }
}
