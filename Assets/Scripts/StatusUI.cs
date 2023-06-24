using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StatusUI : MonoBehaviour
{
    [SerializeField] PlayerStatus PlayerStatus;
    [SerializeField] EnemyStatus EnemyStatus;

    public Text playerHP;
    public Text playerMP;
    public Text enemyHP;
    public Text enemyMP;
    public Text enemyGauge;

    void Update()
    {
        playerHP.text = "HP: " + PlayerStatus.HP.ToString();
        playerMP.text = "MP: " + PlayerStatus.MP.ToString();

        enemyHP.text = "HP: " + EnemyStatus.HP.ToString();
        enemyMP.text = "MP: " + EnemyStatus.MP.ToString();
        enemyGauge.text = "Gauge: " + EnemyStatus.gauge.ToString() + "%";
    }
}
