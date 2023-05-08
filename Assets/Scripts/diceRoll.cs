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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) 
        {
            Debug.Log("ç∂ÉNÉäÉbÉNÇ™ì¸óÕÇ≥ÇÍÇ‹ÇµÇΩ");

            diceNum = Random.Range(1,7);
            diceNum2 = Random.Range(1, 7);
            diceNum3 = Random.Range(1, 7);
            diceNum4 = Random.Range(1,7);
            diceNum5 = Random.Range(1,7);
            Debug.Log(diceNum);
            Debug.Log(diceNum2);
            Debug.Log(diceNum3);
            Debug.Log(diceNum4);
            Debug.Log(diceNum5);
        }
    }

}
