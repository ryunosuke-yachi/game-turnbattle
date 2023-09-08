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

    [SerializeField]
    GameObject DamageCanvas;

    public void PlayerDamageNum(int n)
    {
        int tens = n / 10;
        int ones = n - (tens * 10);

        tensNum.sprite = newImages[tens];
        onesNum.sprite = newImages[ones];
    }

    IEnumerator ShowDamageNum()
    {
        DamageCanvas.SetActive(true);

        yield return new WaitForSeconds(0.5f);

        DamageCanvas.SetActive(false);
    }

    public void StartFunction()
    {
        StartCoroutine(ShowDamageNum());
    }
}
