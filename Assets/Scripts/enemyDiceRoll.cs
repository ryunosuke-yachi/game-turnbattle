using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDiceRoll : MonoBehaviour
{
       [SerializeField]
       EnemyStatus enemyStatus;


       public void enemyDiceRolling()
    {
        switch(enemyStatus.diceSituation)
        {
            case 0:
                enemyNormalDice();
                break;
            case 1:
                enemyLowDice();
                break;
        }
    }

       public void enemyNormalDice()
        {
          for(int i = 0;i<enemyStatus.diceNum.Length;++i)
            {
                enemyStatus.MP = 0;
                enemyStatus.diceNum[i] = Random.Range(1,7);
                Debug.Log(enemyStatus.diceNum[i]);
                enemyStatus.MP += enemyStatus.diceNum[i];
            }
            Debug.Log(enemyStatus.MP);
        }

        public void enemyLowDice()
         {
            enemyStatus.MP = 0;
            for(int i = 0;i<enemyStatus.diceNum.Length;++i)
            {
                enemyStatus.diceNum[i] = Random.Range(1,4);
                Debug.Log(enemyStatus.diceNum[i]);
                enemyStatus.MP += enemyStatus.diceNum[i];
             }
         }
}
