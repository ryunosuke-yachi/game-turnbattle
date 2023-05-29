using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    PlayerStatus playerStatus;
    [SerializeField]
    EnemyStatus enemyStatus;
    // Start is called before the first frame update
    void Start()
    {
        playerStatus.HP = 450;
        playerStatus.MP = 0;
        playerStatus.diceSituation = 0;
        enemyStatus.HP = 500;
        enemyStatus.MP = 0;
        enemyStatus.diceSituation = 0;
        enemyStatus.gauge = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
