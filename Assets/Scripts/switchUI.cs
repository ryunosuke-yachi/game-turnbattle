using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

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
        GAMEOVER,
        OPERATION
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
    GameObject statusUI;
    [SerializeField]
    GameObject GameOverUI;
    [SerializeField]
    TextMeshProUGUI GameOverText;
    [SerializeField]
    Image GameOverPanel;
    [SerializeField]
    GameObject GameClearUI;
    [SerializeField]
    Image GameClearPanel;
    [SerializeField]
    TextMeshProUGUI GameClearText;
    [SerializeField] GameObject OperationUI;
    [SerializeField] GameObject ScreenOpe;
    [SerializeField] GameObject MouseOpe;
    [SerializeField] GameObject SelectSkillUI;
    float BlackOutTime = 0;
    float FadeInTime = 0;
    float StartColor_a = 0f;
    float EndColor_a = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        solveSc = FindObjectOfType<solve>();

        if (playerStatus.MP > 0)
        {
            state = STATE.SELECT;
        }
        else if(playerStatus.IsStart)
        {
            state = STATE.OPERATION;
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
                    //solveSc.solveTurn();
                    isDead();
                    break;
                case STATE.GAMEOVER:
                    UpdateGameOver();
                    displayGameOver();
                    break;
                case STATE.GAMECLEAR:
                    UpdateGameClear();
                    displayGameClear();
                    break;
                case STATE.OPERATION:
                    UpdateOperation();
                    break;

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
        statusUI.SetActive(true);
        GameOverUI.SetActive(false);
        OperationUI.SetActive(false);
        SelectSkillUI.SetActive(false);
    }

    void UpdateSelect()
    {
        diceUI.SetActive(false);
        selectUI.SetActive(true);
        attackUI.SetActive(false);
        guardUI.SetActive(false);
        itemUI.SetActive(false);
        statusUI.SetActive(true);
        GameOverUI.SetActive(false);
        GameClearUI.SetActive(false);
        OperationUI.SetActive(false);
        SelectSkillUI.SetActive(true);
    }

    void UpdateAttack()
    {
        diceUI.SetActive(false);
        selectUI.SetActive(false);
        attackUI.SetActive(true);
        guardUI.SetActive(false);
        itemUI.SetActive(false);
        statusUI.SetActive(true);
        GameOverUI.SetActive(false);
        GameClearUI.SetActive(false);
        OperationUI.SetActive(false);
        SelectSkillUI.SetActive(false);
    }

    void UpdateGuard()
    {
        diceUI.SetActive(false);
        selectUI.SetActive(false);
        attackUI.SetActive(false);
        guardUI.SetActive(true);
        itemUI.SetActive(false);
        statusUI.SetActive(true);
        GameOverUI.SetActive(false);
        GameClearUI.SetActive(false);
        OperationUI.SetActive(false);
        SelectSkillUI.SetActive(false);
    }
    void UpdateItem()
    {
        diceUI.SetActive(false);
        selectUI.SetActive(false);
        attackUI.SetActive(false);
        guardUI.SetActive(false);
        itemUI.SetActive(true);
        statusUI.SetActive(true);
        GameOverUI.SetActive(false);
        GameClearUI.SetActive(false);
        OperationUI.SetActive(false);
        SelectSkillUI.SetActive(false);
    }

    void UpdateDecision()
    {
        diceUI.SetActive(false);
        selectUI.SetActive(false);
        attackUI.SetActive(false);
        guardUI.SetActive(false);
        itemUI.SetActive(false);
        statusUI.SetActive(false);
        GameOverUI.SetActive(false);
        GameClearUI.SetActive(false);
        OperationUI.SetActive(false);
        SelectSkillUI.SetActive(false);
    }

    void UpdateGameOver()
    {
        diceUI.SetActive(false);
        selectUI.SetActive(false);
        attackUI.SetActive(false);
        guardUI.SetActive(false);
        itemUI.SetActive(false);
        statusUI.SetActive(false);
        GameOverUI.SetActive(true);
        GameClearUI.SetActive(false);
        OperationUI.SetActive(false);
        SelectSkillUI.SetActive(false);
    }

    void UpdateGameClear()
    {
        diceUI.SetActive(false);
        selectUI.SetActive(false);
        attackUI.SetActive(false);
        guardUI.SetActive(false);
        itemUI.SetActive(false);
        statusUI.SetActive(false);
        GameOverUI.SetActive(true);
        GameClearUI.SetActive(true);
        OperationUI.SetActive(false);
        SelectSkillUI.SetActive(false);
    }

    void UpdateOperation()
    {
        diceUI.SetActive(false);
        selectUI.SetActive(false);
        attackUI.SetActive(false);
        guardUI.SetActive(false);
        itemUI.SetActive(false);
        statusUI.SetActive(false);
        GameOverUI.SetActive(true);
        GameClearUI.SetActive(true);
        OperationUI.SetActive(true);
        SelectSkillUI.SetActive(false);

        if (Input.GetMouseButtonDown(0))
        {
            if(ScreenOpe.activeSelf)
            {
                ScreenOpe.SetActive(false);
                MouseOpe.SetActive(true);
            }else if (MouseOpe.activeSelf)
            {
                ScreenOpe.SetActive(true);
                MouseOpe.SetActive(false);
                playerStatus.IsStart = false;
                state = STATE.DICE;
            }
        }

        if (Input.GetMouseButtonDown(1))
        {
            if (MouseOpe.activeSelf)
            {
                ScreenOpe.SetActive(true);
                MouseOpe.SetActive(false);
            }
        }
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
        solveSc.solveTurn();
        state = STATE.DECISION;
    }

    public void displayDice()
    {

        SESc.PlayButtonSE();
        state = STATE.DICE;
    }

    public void displayGameOver()
    {
        StartCoroutine(BlackOut());
    }

    public void displayGameClear()
    {
        StartCoroutine(WhiteOut());
    }
    IEnumerator BlackOut()
    {
        Color CurrentColor = new Color(0, 0, 0, Mathf.Lerp(StartColor_a, EndColor_a, BlackOutTime));
        BlackOutTime += 1.0f * Time.deltaTime;
        GameOverPanel.color = CurrentColor;
        if (GameOverPanel.color.a >= EndColor_a) yield return StartCoroutine(FadeInGameOver());
    }

    IEnumerator FadeInGameOver()
    {
        Color CurrentColor = new Color(1, 1, 1, Mathf.Lerp(StartColor_a, EndColor_a, FadeInTime));
        FadeInTime += 0.5f * Time.deltaTime;
        GameOverText.color = CurrentColor;
        yield return null;
        if(GameOverText.color.a >= EndColor_a)
        {
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene("Title");
        }
    }

    IEnumerator WhiteOut()
    {
        Color CurrentColor = new Color(0, 0, 0, Mathf.Lerp(StartColor_a, EndColor_a, BlackOutTime));
        BlackOutTime += 1.0f * Time.deltaTime;
        GameClearPanel.color = CurrentColor;
        if (GameClearPanel.color.a >= EndColor_a) yield return StartCoroutine(FadeInGameClear()); 
    }

    IEnumerator FadeInGameClear()
    {
        Color CurrentColor = new Color(1, 1, 1, Mathf.Lerp(StartColor_a, EndColor_a, FadeInTime));
        FadeInTime += 0.5f * Time.deltaTime;
        GameClearText.color = CurrentColor;
        yield return null;
        if (GameClearText.color.a >= EndColor_a)
        {
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene("Title");
        }
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