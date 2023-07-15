using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skillUI : MonoBehaviour
{
    [SerializeField]
    skillData playerSkillData;

    SpriteRenderer[] btnImage = new SpriteRenderer[5];

    public Button[] buttons;
    public Sprite[] newImages;

    public void changeUI()
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            Button button = buttons[i];
            Image buttonImage = button.GetComponent<Image>();

            if (buttonImage != null)
            {
                int Num = playerSkillData.skillButtons[i].skillID;
                buttonImage.sprite = newImages[Num];
            }
        }
    }

    public int UsedUI(int n)
    {
        Button button = buttons[n];
        Image buttonImage = button.GetComponent<Image>();

        if(playerSkillData.skillInfoList[n].isSelect == true)
        {
            int Num = playerSkillData.skillButtons[n].skillID;
            buttonImage.sprite = newImages[Num + 8];
        }
        else if(playerSkillData.skillInfoList[n].isSelect == false)
        {
            int Num = playerSkillData.skillButtons[n].skillID;
            buttonImage.sprite = newImages[Num];
        }
        return 0;
    }
}

