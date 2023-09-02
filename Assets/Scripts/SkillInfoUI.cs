using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SkillInfoUI : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    skillData playerSkillData;

    public GameObject SkillInfo;
    public GameObject SkillButtons;
    public Image CardImage;
    public Text Name;
    public Text MP;
    public Text Explain;
    public Sprite[] newImages;

    // Start is called before the first frame update
    void Start()
    {
        //SkillInfo.SetActive(false);
        //Debug.Log("skillInfo_false");
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void showSkillInfoUI(int spriteIndex)
    {
        Debug.Log("now");
        SkillButtons.SetActive(false);

        int id = playerSkillData.skillButtons[spriteIndex].skillID;
        if (spriteIndex >= 0 && spriteIndex < newImages.Length)
        {
            CardImage.sprite = newImages[id];
            Name.text = playerSkillData.skillInfoList[id].Name;
            MP.text = "MP:" + playerSkillData.skillInfoList[id].MP;
            Explain.text = playerSkillData.skillInfoList[id].Effect;
        }
    }

    void closeInfoUI()
    {
        SkillButtons.SetActive(true);
        SkillInfo.SetActive(false);
    }

    public void OnPointerClick(PointerEventData pointerEventData)
    {
        closeInfoUI();
    }
}
