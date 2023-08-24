using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchUI : MonoBehaviour
{
    solve solveSc;
    public GameObject Button_SE;
    SE SESc;
    public PlayerStatus playerStatus;
    public EnemyStatus enemyStatus;
    public enum STATE
    {
        DICE = 0,
        SELECT,
        ATTACK,
        GUARD,
        ITEM,
        DECISION,
        GAMECLEAR,
        GAMEOVER
    }
    public STATE state;
    [SerializeField]
    GameObject diceUI;
    [SerializeField]
    GameObject selectUI;
    [SerializeField]
    GameObject attackUI;
    [SerializeField]
    GameObject guardUI;
    [SerializeField]
    GameObject itemUI;
    [SerializeField]
    GameObject statuUI;
    // Start is called before the first frame update
    void Start()
    {
        solveSc = FindObjectOfType<solve>();

        if (playerStatus.MP > 0)
        {
            state = STATE.SELECT;
        }
        else 
        {
            state = STATE.DICE;
        }
        SESc = Button_SE.GetComponent<SE>();
    }

    // Update is called once per frame
    void Update()
    {
        {
            switch (state)
            {
                case STATE.DICE:
                    UpdateDice();
                    break;
                case STATE.SELECT:
                    UpdateSelect();
                    break;
                case STATE.ATTACK:
                    UpdateAttack();
                    break;
                case STATE.GUARD:
                    UpdateGuard();
                    break;
                case STATE.ITEM:
                    UpdateItem();
                    break;
                case STATE.DECISION:
                    UpdateDecision();
                    solveSc.solveTurn();
                    isDead();
                    break;
                //case gameClear
                //case gameOver
            }
        }


    }

    void UpdateDice()
    {
        diceUI.SetActive(true);
        selectUI.SetActive(false);
        attackUI.SetActive(false);
        guardUI.SetActive(false);
        itemUI.SetActive(false);
        statuUI.SetActive(true);
    }

    void UpdateSelect()
    {
        diceUI.SetActive(false);
        selectUI.SetActive(true);
        attackUI.SetActive(false);
        guardUI.SetActive(false);
        itemUI.SetActive(false);
        statuUI.SetActive(true);

    }

    void UpdateAttack()
    {
        diceUI.SetActive(false);
        selectUI.SetActive(false);
        attackUI.SetActive(true);
        guardUI.SetActive(false);
        itemUI.SetActive(false);
        statuUI.SetActive(true);

    }

    void UpdateGuard()
    {
        diceUI.SetActive(false);
        selectUI.SetActive(false);
        attackUI.SetActive(false);
        guardUI.SetActive(true);
        itemUI.SetActive(false);
        statuUI.SetActive(true);

    }
    void UpdateItem()
    {
        diceUI.SetActive(false);
        selectUI.SetActive(false);
        attackUI.SetActive(false);
        guardUI.SetActive(false);
        itemUI.SetActive(true);
        statuUI.SetActive(true);

    }

    void UpdateDecision()
    {
        diceUI.SetActive(false);
        selectUI.SetActive(false);
        attackUI.SetActive(false);
        guardUI.SetActive(false);
        itemUI.SetActive(false);
        statuUI.SetActive(false);
    }


    public void displayAttack()
    {
        SESc.PlayButtonSE();
        state = STATE.ATTACK;
    }
    public void displayGuard()
    {
        SESc.PlayButtonSE();
        state = STATE.GUARD;
    }
    public void displayItem()
    {
        SESc.PlayButtonSE();
        state = STATE.ITEM;
    }

    public void displaySelect()
    {
        SESc.PlayButtonSE();
        state = STATE.SELECT;
    }

    public void displayDecision()
    {
        state = STATE.DECISION;
    }

    public void displayDice()
    {
        SESc.PlayButtonSE();
        state = STATE.DICE;
    }


    private void isDead()
    {
        if (playerStatus.HP <= 0) playerStatus.isDead = true;
        if (enemyStatus.HP <= 0) enemyStatus.isDead = true;
        if(playerStatus.isDead)
        {
            state = STATE.GAMEOVER;
        }
        if(enemyStatus.isDead)
        {
            state = STATE.GAMECLEAR;
        }
    }
}