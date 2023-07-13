using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class skillSel : MonoBehaviour, IPointerClickHandler
{
    private skillCon SkillCon;

    //スキル情報を持っているScriptableObject
    [SerializeField]
    skillData playerSkillData; // これが、今持っているスキルのデータ

    [SerializeField]
    PlayerStatus PlayerStatus;

    GameObject clickedGameObject;

    int[] buttonNum = new int[8];

    public void Start()
    {
        SkillCon = FindObjectOfType<skillCon>();

        playerSkillData.skillButtons.Clear();
        for (int i = 0; i < 8; i++)
        {
            skillButton b = new skillButton();
            b.skillID = Random.Range(0, 5);
            if(i > 5)
            {
                b.skillID = i;
            }
            b.isSelect = false;
            playerSkillData.skillButtons.Add(b);
            buttonNum[i] = b.skillID;
        }
    }

    private void SelButton_n(int n)
    {
        if (playerSkillData.skillButtons[n].isSelect == false)
        {
            int id = playerSkillData.skillButtons[n].skillID;
            if(PlayerStatus.MP >= playerSkillData.skillInfoList[id].MP)
            {
                playerSkillData.skillButtons[n].isSelect = true;
                Debug.Log(playerSkillData.skillInfoList[id].Name);
                SkillCon.AddToList(id);
                PlayerStatus.MP -= playerSkillData.skillInfoList[id].MP;
                Debug.Log(PlayerStatus.MP);
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
            SkillCon.RemoveFromList(n);
            PlayerStatus.MP += playerSkillData.skillInfoList[id].MP;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if(eventData.button == PointerEventData.InputButton.Left)
        {
            clickedGameObject = GameObject.Find(name);
            Debug.Log(clickedGameObject.name);//ゲームオブジェクトの名前を出力
            Debug.Log(buttonNum[0]);

            string str = clickedGameObject.name;
            switch (str)
            {
                case "Atk_0":
                    SelButton_n(0);
                    break;
                case "Atk_1":
                    SelButton_n(1);
                    break;
                case "Atk_2":
                    SelButton_n(2);
                    break;
                case "Atk_3":
                    SelButton_n(3);
                    break;
                case "Atk_4":
                    SelButton_n(4);
                    break;
                case "Def_5":
                    SelButton_5();
                    break;
                case "Item_6":
                    SelButton_6();
                    break;
                case "Item_7":
                    SelButton_7();
                    break;
            }
        }
        else if(eventData.button == PointerEventData.InputButton.Right)
        {
            clickedGameObject = GameObject.Find(name);
            Debug.Log(clickedGameObject.name);
            string str = clickedGameObject.name;
            switch (str)
            {
                case "Atk_0":
                        
                    break;
                case "Atk_1":
                        
                    break;
                case "Atk_2":
                        
                    break;
                case "Atk_3":
                        
                    break;
                case "Atk_4":
                        
                    break;
                case "Def_5":

                    break;
                case "Item_6":

                    break;
                case "Item_7":

                    break;
            }
        }
    }

    //それぞれのボタンが押されたときのフラグの切り替え
    //public void SelButton_0()
    //{
    //    SelButton_n(0);
    //}

    //public void SelButton_1()
    //{
    //    SelButton_n(1);
    //}

    //public void SelButton_2()
    //{
    //    SelButton_n(2);
    //}

    //public void SelButton_3()
    //{
    //    SelButton_n(3);
    //}

    //public void SelButton_4()
    //{
    //    SelButton_n(4);
    //}

    public void SelButton_5()
    {
        //SelButton_n(5);
        if(playerSkillData.skillInfoList[5].isSelect == false)
        {
            if(PlayerStatus.MP >= playerSkillData.skillInfoList[5].MP)
            {
                playerSkillData.skillInfoList[5].isSelect = true;
                Debug.Log(playerSkillData.skillInfoList[5].Name);
                SkillCon.AddToList(5);
                PlayerStatus.MP -= playerSkillData.skillInfoList[5].MP;
            }
            else
            {
                Debug.Log("MPが足りません");
            }
        }
        else if(playerSkillData.skillInfoList[5].isSelect ==true)
        {
            playerSkillData.skillInfoList[5].isSelect = false;
            SkillCon.RemoveFromList(5);
            PlayerStatus.MP += playerSkillData.skillInfoList[5].MP;
        }
    }

    public void SelButton_6()
    {
        //SelButton_n(6);
        if (playerSkillData.skillInfoList[6].isSelect == false)
        {
            if (PlayerStatus.MP >= playerSkillData.skillInfoList[6].MP)
            {
                playerSkillData.skillInfoList[6].isSelect = true;
                Debug.Log(playerSkillData.skillInfoList[6].Name);
                SkillCon.AddToList(6);
                PlayerStatus.MP -= playerSkillData.skillInfoList[6].MP;
            }
            else
            {
                Debug.Log("MPが足りません");
            }
        }
        else if (playerSkillData.skillInfoList[6].isSelect == true)
        {
            playerSkillData.skillInfoList[6].isSelect = false;
            SkillCon.RemoveFromList(6);
            PlayerStatus.MP += playerSkillData.skillInfoList[6].MP;
        }
    }

    public void SelButton_7()
    {
        //SelButton_n(7);
        if (playerSkillData.skillInfoList[7].isSelect == false)
        {
            if (PlayerStatus.MP >= playerSkillData.skillInfoList[7].MP)
            {
                playerSkillData.skillInfoList[7].isSelect = true;
                Debug.Log(playerSkillData.skillInfoList[7].Name);
                SkillCon.AddToList(7);
                PlayerStatus.MP -= playerSkillData.skillInfoList[7].MP;
            }
            else
            {
                Debug.Log("MPが足りません");
            }
        }
        else if (playerSkillData.skillInfoList[7].isSelect == true)
        {
            playerSkillData.skillInfoList[7].isSelect = false;
            SkillCon.RemoveFromList(7);
            PlayerStatus.MP += playerSkillData.skillInfoList[7].MP;
        }
    }
}
