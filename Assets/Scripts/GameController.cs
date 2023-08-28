using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField]
    PlayerStatus playerStatus;
    [SerializeField]
    EnemyStatus enemyStatus;

    [SerializeField]
    GameObject SkillButtons;
    skillSel skillSelSc;
    // Start is called before the first frame update
    void Start()
    {
        //playerStatus.HP = 450;
        //playerStatus.diceSituation = 0;
        //enemyStatus.HP = 500;
        //enemyStatus.diceSituation = 0;
        //enemyStatus.gauge = 0;
        skillSelSc = SkillButtons.GetComponent<skillSel>();
        skillSelSc.setInitialValues();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
