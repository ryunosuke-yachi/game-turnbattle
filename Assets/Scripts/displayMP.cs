using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayMP : MonoBehaviour
{
    public EnemyStatus enemyStatus;
    public PlayerStatus playerStatus;
    public Text playerMP;
    public Text enemyMP;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerMP.text = playerStatus.MP.ToString();
        enemyMP.text = enemyStatus.MP.ToString();
    }
}
