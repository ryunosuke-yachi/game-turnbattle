using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchUI : MonoBehaviour
{
    public enum STATE
    {
        DICE = 0,
        SELECT,
        ATTACK,
        GUARD,
        ITEM,
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
    // Start is called before the first frame update
    void Start()
    {
        state = STATE.DICE;
    }

    // Update is called once per frame
    void Update()
    {
        switch(state)
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
        }
    }

    void UpdateDice()
    {
        diceUI.SetActive(true);
        selectUI.SetActive(false);
        attackUI.SetActive(false);
        guardUI.SetActive(false);
        itemUI.SetActive(false);
    }

    void UpdateSelect()
    {
        diceUI.SetActive(false);
        selectUI.SetActive(true);
        attackUI.SetActive(false);
        guardUI.SetActive(false);
        itemUI.SetActive(false);
    }

    void UpdateAttack()
    {
        diceUI.SetActive(false);
        selectUI.SetActive(false);
        attackUI.SetActive(true);
        guardUI.SetActive(false);
        itemUI.SetActive(false);
    }

    void UpdateGuard()
    {
        diceUI.SetActive(false);
        selectUI.SetActive(false);
        attackUI.SetActive(false);
        guardUI.SetActive(true);
        itemUI.SetActive(false);
    }
    void UpdateItem()
    {
        diceUI.SetActive(false);
        selectUI.SetActive(false);
        attackUI.SetActive(false);
        guardUI.SetActive(false);
        itemUI.SetActive(true);
    }
    public void displayAttack()
    {
        state = STATE.ATTACK;
    }
    public void displayGuard()
    {
        state = STATE.GUARD;
    }
    public void displayItem()
    {
        state = STATE.ITEM;
    }

    public void displaySelect()
    {
        state = STATE.SELECT;
    }
}
