using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public Text playerHP;
    public Text playerMP;
    public Text enemyMP;
    [SerializeField]
    PlayerStatus playerStatus;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerHP.text = "HP: " + playerStatus.HP.ToString();
    }
}
