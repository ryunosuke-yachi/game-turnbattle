using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayGauge : MonoBehaviour
{
    [SerializeField] Image CurrentGauge;//ìGÇÃåªç›ÇÃÉQÅ[ÉWäÑçá
    [SerializeField] EnemyStatus enemyStatus;
    
    // Start is called before the first frame update
    void Start()
    {
        
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
    }
}
