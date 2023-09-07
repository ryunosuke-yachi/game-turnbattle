using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillListViewer : MonoBehaviour
{
    public GameObject imagesBox;
    public Image skillImage;
    public Sprite[] newImages;

    skillCon skillConSc;

    int ImagesNum;

    // Start is called before the first frame update
    void Start()
    {
        skillConSc = FindObjectOfType<skillCon>();
        imagesBox.SetActive(false);

        ImagesNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ListViewer()
    {
        if (skillConSc.buttonList.Count == 0)
        {
            imagesBox.SetActive(false);
        }
        else if(skillConSc.buttonList.Count > 0)
        {
            imagesBox.SetActive(true);

            NextImages(skillConSc.buttonList[0]);
        }
    }
    
    public void OnClick()
    {
        Debug.Log(ImagesNum);
        ImagesNum += 1;
        if (ImagesNum < skillConSc.buttonList.Count)
        {
            NextImages(skillConSc.buttonList[ImagesNum]);
        }
        else if (ImagesNum >= skillConSc.buttonList.Count)
        {
            ImagesNum = 0;
            NextImages(skillConSc.buttonList[ImagesNum]);
        }
    }

    void NextImages(int n)
    {
        skillImage.sprite = newImages[n];
    }
}
