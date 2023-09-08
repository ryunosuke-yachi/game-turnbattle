using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DamageUI : MonoBehaviour
{
    [SerializeField]
    Sprite[] newImages;

    [SerializeField]
    Image tensNum, onesNum;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerDamageNum(int n)
    {
        int tens = n / 10;
        int ones = n - (tens * 10);

        tensNum.sprite = newImages[tens];
        onesNum.sprite = newImages[ones];
    }
}
