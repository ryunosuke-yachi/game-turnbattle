using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceRoll : MonoBehaviour
{

    [SerializeField]
    PlayerStatus playerStatus;

    [SerializeField] 
    EnemyStatus enemyStatus;
    [SerializeField] private GameObject mainCan;
    [SerializeField]
    private GameObject DiceButton;
    private GameObject mainPreInstantiate;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }



    public void DiceRolling()
    {
        switch (playerStatus.diceSituation)
        {
            case 0:
                if(enemyStatus.diceSituation == 0) {
                    NormalDice();
                    enemyNormalDice();
                    mainPreInstantiate = GameObject.Instantiate(mainCan) as GameObject;
                    DiceButton.SetActive(false);
                    
                } else if(enemyStatus.diceSituation == 1) {
                    NormalDice();
                    enemyLowDice();
                    DiceButton.SetActive(false);
                    mainPreInstantiate = GameObject.Instantiate(mainCan) as GameObject;
                }

                break;
            case 1:
                if(enemyStatus.diceSituation == 0) {
                    highDice();
                    enemyNormalDice();
                    DiceButton.SetActive(false);
                    mainPreInstantiate = GameObject.Instantiate(mainCan) as GameObject;
                }
                if(enemyStatus.diceSituation == 1) {
                    highDice();
                    enemyLowDice();
                    DiceButton.SetActive(false);
                    mainPreInstantiate = GameObject.Instantiate(mainCan) as GameObject;
                }
                break;

        }

       
    }

    public void NormalDice()
    {
        
        
        playerStatus.MP = 0;
        Debug.Log("ノーマルダイスを振ります");

        for (int i = 0; i < playerStatus.diceNum.Length; ++i)
        {
            playerStatus.diceNum[i] = Random.Range(1, 7);
            Debug.Log(playerStatus.diceNum[i]);
            playerStatus.MP += playerStatus.diceNum[i];
        }
        Debug.Log("プレイヤーMP:" + playerStatus.MP);
    }   

    public void highDice()
    {
        playerStatus.MP = 0;

        Debug.Log("456ダイスを振ります");

        for(int i = 0; i < playerStatus.diceNum.Length; ++i)
        {
            playerStatus.diceNum[i] = Random.Range(4,7);
            Debug.Log(playerStatus.diceNum[i]);
            playerStatus.MP += playerStatus.diceNum[i];
        }

        Debug.Log("プレイヤーMP:"　+ playerStatus.MP);
    }

    public void enemyNormalDice() {
        enemyStatus.MP = 0;
        for(int i = 0; i < enemyStatus.diceNum.Length; ++i) {
            enemyStatus.diceNum[i] = Random.Range(1, 7);
            Debug.Log(enemyStatus.diceNum[i]);
            enemyStatus.MP += enemyStatus.diceNum[i];
        }
        Debug.Log("敵MP:" + enemyStatus.MP);
    }

    public void enemyLowDice() {
        enemyStatus.MP = 0;
        for(int i = 0; i < enemyStatus.diceNum.Length; ++i) {
            enemyStatus.diceNum[i] = Random.Range(1, 4);
            Debug.Log(enemyStatus.diceNum[i]);
            enemyStatus.MP += enemyStatus.diceNum[i];
        }
        Debug.Log("敵MP:" + enemyStatus.MP);
    }
}
