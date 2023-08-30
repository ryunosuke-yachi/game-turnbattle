using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class skillSel : MonoBehaviour, IPointerClickHandler
{
    skillCon skillConSc;
    skillUI skillUISc;
    public GameObject Button_SE;
    SE SESc;
    public GameObject PlayerMP;
    PlayerStatusUIManager PlayerStatusUIManagerSc;

    //SkillInfoUI SkillInfoUI;
    public GameObject SkillInfo;

    public GameObject GameController;

    //スキル情報を持っているScriptableObject
    [SerializeField]
    skillData playerSkillData; // これが、今持っているスキルのデータ

    [SerializeField]
    PlayerStatus PlayerStatus;

    GameObject clickedGameObject;

    public bool usedFunction = false;

    public void Start()
    {
        skillConSc = FindObjectOfType<skillCon>();
        skillUISc = FindObjectOfType<skillUI>();
        SESc = Button_SE.GetComponent<SE>();
        PlayerStatusUIManagerSc = PlayerMP.GetComponent<PlayerStatusUIManager>();
        //SkillInfo = GetComponent<GameObject>();
        //setInitialValues();

        for(int i = 0; i < 8; i++)
        {
            playerSkillData.skillInfoList[i].isSelect = false;
            //playerSkillData.skillInfoList[i].turnLimit = 0;
        }
    }

    public void setInitialValues() //スキル番号の初期化処理
    {
        if (usedFunction ==false)
        {
            skillConSc = FindObjectOfType<skillCon>();
            skillUISc = FindObjectOfType<skillUI>();

            playerSkillData.skillButtons.Clear();
            for (int i = 0; i < 8; i++)
            {
                skillButton b = new skillButton();
                b.skillID = Random.Range(0, 5);
                if (i > 4)
                {
                    b.skillID = i;
                }
                b.isSelect = false;
                playerSkillData.skillButtons.Add(b);
            }

            skillUISc.changeUI();
        }
        
    }

    private void SelButton_n(int n) //攻撃スキルの選択処理
    {
        if (playerSkillData.skillButtons[n].isSelect == false)
        {
            int id = playerSkillData.skillButtons[n].skillID;
            if(PlayerStatus.MP >= playerSkillData.skillInfoList[id].MP)
            {
                playerSkillData.skillButtons[n].isSelect = true;
                Debug.Log(playerSkillData.skillInfoList[id].Name);
                skillConSc.AddToList(id);
                PlayerStatus.MP -= playerSkillData.skillInfoList[id].MP;
                Debug.Log(PlayerStatus.MP);
                skillUISc.UsedUI(n);
            }
            else
            {
                Debug.Log("MPが足りません");
            }
        }
        else if (playerSkillData.skillButtons[n].isSelect == true)
        {
            playerSkillData.skillButtons[n].isSelect = false;
            int id = playerSkillData.skillButtons[n].skillID;
            skillConSc.RemoveFromList(id);
            PlayerStatus.MP += playerSkillData.skillInfoList[id].MP;
            skillUISc.UsedUI(n);
        }
        //skillUISc.UsedUI(n);
    }

    public void OnPointerClick(PointerEventData eventData) //クリック判別と対応する処理
    {
        if(eventData.button == PointerEventData.InputButton.Left)
        {
            clickedGameObject = GameObject.Find(name);
            Debug.Log(clickedGameObject.name);//ゲームオブジェクトの名前を出力

            string str = clickedGameObject.name;
            switch (str)
            {
                case "Atk_0":
                    SelButton_n(0);
                    SESc.PlayButtonSE();
                    PlayerStatusUIManagerSc.CalculateMPRatio();
                    break;
                case "Atk_1":
                    SelButton_n(1);
                    SESc.PlayButtonSE();
                    PlayerStatusUIManagerSc.CalculateMPRatio();
                    break;
                case "Atk_2":
                    SelButton_n(2);
                    SESc.PlayButtonSE();
                    PlayerStatusUIManagerSc.CalculateMPRatio();
                    break;
                case "Atk_3":
                    SelButton_n(3);
                    SESc.PlayButtonSE();
                    PlayerStatusUIManagerSc.CalculateMPRatio();
                    break;
                case "Atk_4":
                    SelButton_n(4);
                    SESc.PlayButtonSE();
                    PlayerStatusUIManagerSc.CalculateMPRatio();
                    break;
                case "Def_5":
                    SelButton_5();
                    SESc.PlayButtonSE();
                    PlayerStatusUIManagerSc.CalculateMPRatio();
                    break;
                case "Item_6":
                    SelButton_6();
                    SESc.PlayButtonSE();
                    PlayerStatusUIManagerSc.CalculateMPRatio();
                    break;
                case "Item_7":
                    SelButton_7();
                    SESc.PlayButtonSE();
                    PlayerStatusUIManagerSc.CalculateMPRatio();
                    break;
            }
        }
        else if(eventData.button == PointerEventData.InputButton.Right)
        {
            clickedGameObject = GameObject.Find(name);
            Debug.Log(clickedGameObject.name);
            string str = clickedGameObject.name;
            SkillInfoUI SkillInfoUISc = GameController.GetComponent<SkillInfoUI>();
            switch (str)
            {
                case "Atk_0":
                    //SkillInfoUI SkillInfoUISc = GameController.GetComponent<SkillInfoUI>();
                    SkillInfo.SetActive(true);
                    SkillInfoUISc.showSkillInfoUI(0);
                    break;
                case "Atk_1":
                    SkillInfo.SetActive(true);
                    SkillInfoUISc.showSkillInfoUI(1);
                    break;
                case "Atk_2":
                    SkillInfo.SetActive(true);
                    SkillInfoUISc.showSkillInfoUI(2);
                    break;
                case "Atk_3":
                    SkillInfo.SetActive(true);
                    SkillInfoUISc.showSkillInfoUI(3);
                    break;
                case "Atk_4":
                    SkillInfo.SetActive(true);
                    SkillInfoUISc.showSkillInfoUI(4);
                    break;
                case "Def_5":
                    SkillInfo.SetActive(true);
                    SkillInfoUISc.showSkillInfoUI(5);
                    break;
                case "Item_6":
                    SkillInfo.SetActive(true);
                    SkillInfoUISc.showSkillInfoUI(6);
                    break;
                case "Item_7":
                    SkillInfo.SetActive(true);
                    SkillInfoUISc.showSkillInfoUI(7);
                    break;
            }
        }
    }

    public void SelButton_5() //防御スキルの選択処理
    {
        if (playerSkillData.skillInfoList[5].isSelect == false)
        {
            if (PlayerStatus.MP >= playerSkillData.skillInfoList[5].MP)
            {
                playerSkillData.skillInfoList[5].isSelect = true;
                Debug.Log(playerSkillData.skillInfoList[5].Name);
                skillConSc.AddToList(5);
                PlayerStatus.MP -= playerSkillData.skillInfoList[5].MP;
                skillUISc.UsedUI(5);
            }
            else
            {
                Debug.Log("MPが足りません");
            }
        }
        else if (playerSkillData.skillInfoList[5].isSelect == true)
        {
            playerSkillData.skillInfoList[5].isSelect = false;
            skillConSc.RemoveFromList(5);
            PlayerStatus.MP += playerSkillData.skillInfoList[5].MP;
            skillUISc.UsedUI(5);
        }
    } 

    public void SelButton_6() //アイテムスキルの選択処理１
    {
        if(playerSkillData.skillInfoList[6].turnLimit == 0)
        {
            if (playerSkillData.skillInfoList[6].isSelect == false)
            {
                if (PlayerStatus.MP >= playerSkillData.skillInfoList[6].MP)
                {
                    playerSkillData.skillInfoList[6].isSelect = true;
                    Debug.Log(playerSkillData.skillInfoList[6].Name);
                    skillConSc.AddToList(6);
                    PlayerStatus.MP -= playerSkillData.skillInfoList[6].MP;
                    skillUISc.UsedUI(6);
                }
                else
                {
                    Debug.Log("MPが足りません");
                }
            }
            else if (playerSkillData.skillInfoList[6].isSelect == true)
            {
                playerSkillData.skillInfoList[6].isSelect = false;
                skillConSc.RemoveFromList(6);
                PlayerStatus.MP += playerSkillData.skillInfoList[6].MP;
                skillUISc.UsedUI(6);
            }
        }
        else
        {
            Debug.Log("まだ使用できません");
        }
        
    }

    public void SelButton_7() //アイテムスキルの選択処理２
    {
        if (playerSkillData.skillInfoList[7].turnLimit == 0)
        {
            if (playerSkillData.skillInfoList[7].isSelect == false)
            {
                if (PlayerStatus.MP >= playerSkillData.skillInfoList[7].MP)
                {
                    playerSkillData.skillInfoList[7].isSelect = true;
                    Debug.Log(playerSkillData.skillInfoList[7].Name);
                    skillConSc.AddToList(7);
                    PlayerStatus.MP -= playerSkillData.skillInfoList[7].MP;
                    skillUISc.UsedUI(7);
                }
                else
                {
                    Debug.Log("MPが足りません");
                }
            }
            else if (playerSkillData.skillInfoList[7].isSelect == true)
            {
                playerSkillData.skillInfoList[7].isSelect = false;
                skillConSc.RemoveFromList(7);
                PlayerStatus.MP += playerSkillData.skillInfoList[7].MP;
                skillUISc.UsedUI(7);
            }
        }
        else
        {
            Debug.Log("まだ使用できません");
        }
        
    }
}
