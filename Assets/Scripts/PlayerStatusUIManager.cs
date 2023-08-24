using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStatusUIManager : MonoBehaviour
{
    [SerializeField] PlayerStatus PlayerStatus;
    [SerializeField] Image HPBar, MPBar;
    Text playerHP;
    Text playerMP;

    float MaxHP;
    float currentHP;
    float MaxMP;
    float currentMP;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        CalculateHPRatio();
    }

    void CalculateHPRatio()
    {
        MaxHP = 450;
        currentHP = PlayerStatus.HP;

        float ratio = (currentHP / MaxHP);
        HPBar.fillAmount = ratio;
    }

    public void CalculateMPRatio()
    {
        MaxMP = PlayerStatus.MaxMP;
        currentMP = PlayerStatus.MP;

        float ratio = (currentMP / MaxMP);
        MPBar.fillAmount = ratio;
        //Debug.Log("now");
    }
}
