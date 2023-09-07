using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayGauge : MonoBehaviour
{
    [SerializeField] Image CurrentGauge;//ìGÇÃåªç›ÇÃÉQÅ[ÉWäÑçá
    [SerializeField] EnemyStatus enemyStatus;
    [SerializeField] Sprite[] enemySkill;
    [SerializeField] GameObject enemySkillButton;
    [SerializeField] enemySkillData enemyskillData;
    Image enemySkillButtonImage;
    // Start is called before the first frame update
    void Start()
    {
        enemySkillButtonImage = enemySkillButton.GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        CurrentGauge.fillAmount = (float)enemyStatus.gauge / (float)enemyStatus.maxGauge;
        if(CurrentGauge.fillAmount == 1)
        {
            CurrentGauge.color = Color.yellow;
        }
        else
        {
            CurrentGauge.color = new Color32(0, 170, 255, 255);
        }

        DisplayEnemySkill();
    }

    void DisplayEnemySkill()
    {
        if(enemyStatus.MP == 0)
        {
            enemySkillButton.SetActive(false);
        }
        else if (enemyStatus.gauge == enemyStatus.maxGauge)
        {
            //ult;
        }
        else if (enemyStatus.MP <= enemyskillData.enemySkillInfoList[0].maxMP && enemyStatus.gauge < enemyStatus.maxGauge)
        {
            enemySkillButton.SetActive(true);
            enemySkillButtonImage.sprite = enemySkill[0]; 
        }
        else if (enemyStatus.MP <= enemyskillData.enemySkillInfoList[1].maxMP && enemyStatus.gauge < enemyStatus.maxGauge)
        {
            enemySkillButton.SetActive(true);
            enemySkillButtonImage.sprite = enemySkill[1];
        }
        else if (enemyStatus.MP <= enemyskillData.enemySkillInfoList[2].maxMP && enemyStatus.gauge < enemyStatus.maxGauge)
        {
            enemySkillButton.SetActive(true);
            enemySkillButtonImage.sprite = enemySkill[2];
        }
        else if (enemyStatus.MP <= enemyskillData.enemySkillInfoList[3].maxMP && enemyStatus.gauge < enemyStatus.maxGauge)
        {
            enemySkillButton.SetActive(true);
            enemySkillButtonImage.sprite = enemySkill[3];
        }
    }
}
