using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayMp : MonoBehaviour
{
    public Text playerMp;
    public GameObject dice;
    diceRoll diceSc;
    // Start is called before the first frame update
    void Start()
    {
        diceSc = dice.GetComponent<diceRoll>();
    }

    // Update is called once per frame
    void Update()
    {
        playerMp.text = "MP:" + diceSc.mp.ToString();
    }
}
