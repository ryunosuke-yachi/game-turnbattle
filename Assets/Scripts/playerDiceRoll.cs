using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDiceRoll : MonoBehaviour
{

    [SerializeField]
    PlayerStatus playerStatus;

    [SerializeField] 
    // Start is called before the first frame update
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
                NormalDice();
                break;
            case 1:
                highDice();
                break;

        }

       
    }

    public void NormalDice()
    {
        
        
        playerStatus.MP = 0;
        Debug.Log("�m�[�}���_�C�X��U��܂�");

        for (int i = 0; i < playerStatus.diceNum.Length; ++i)
        {
            playerStatus.diceNum[i] = Random.Range(1, 7);
            Debug.Log(playerStatus.diceNum[i]);
            playerStatus.MP += playerStatus.diceNum[i];
        }
        Debug.Log(playerStatus.MP);
    }   

    public void highDice()
    {
        playerStatus.MP = 0;

        Debug.Log("456�_�C�X��U��܂�");

        for(int i = 0; i < playerStatus.diceNum.Length; ++i)
        {
            playerStatus.diceNum[i] = Random.Range(4,7);
            Debug.Log(playerStatus.diceNum[i]);
            playerStatus.MP += playerStatus.diceNum[i];
        }

        Debug.Log(playerStatus.MP);
    }

}
