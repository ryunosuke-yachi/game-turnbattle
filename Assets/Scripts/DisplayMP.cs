using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayMP : MonoBehaviour
{
    [SerializeField]
    Sprite[] Number;//Še”š‚Ì‰æ‘œ
    [SerializeField]
    Image tensPlace, onesPlace;//10‚ÌˆÊA‚P‚ÌˆÊ‚Ì‰æ‘œ
    [SerializeField]
    EnemyStatus enemyStatus;
    int tensPlaceNum, onesPlaceNum;//10‚ÌˆÊ‚Ì”šA1‚ÌˆÊ‚Ì”š
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ChooseNum();
    }

    void ChooseNum()
    {
        int MP = enemyStatus.MP;
        tensPlaceNum = MP / 10;
        onesPlaceNum = MP % 10;
        //Debug.Log(tensPlaceNum + " " + onesPlaceNum);
        switch(tensPlaceNum)
        {
            case 0:
                tensPlace.sprite = Number[0];
                break;
            case 1:
                tensPlace.sprite = Number[1];
                break;
            case 2:
                tensPlace.sprite = Number[2];
                break;
            case 3:
                tensPlace.sprite = Number[3];
                break;
        }
        switch(onesPlaceNum)
        {
            case 0:
                onesPlace.sprite = Number[0];
                break;
            case 1:
                onesPlace.sprite = Number[1];
                break;
            case 2:
                onesPlace.sprite = Number[2];
                break;
            case 3:
                onesPlace.sprite = Number[3];
                break;
            case 4:
                onesPlace.sprite = Number[4];
                break;
            case 5:
                onesPlace.sprite = Number[5];
                break;
            case 6:
                onesPlace.sprite = Number[6];
                break;
            case 7:
                onesPlace.sprite = Number[7];
                break;
            case 8:
                onesPlace.sprite = Number[8];
                break;
            case 9:
                onesPlace.sprite = Number[9];
                break;

        }
    }
}
