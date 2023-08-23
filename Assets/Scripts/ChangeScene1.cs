using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene1 : MonoBehaviour
{
    public GameObject Button_SE;
    SE SESc;
    // Start is called before the first frame update
    void Start()
    {
        SESc = Button_SE.GetComponent<SE>();
    }

    public void DiceScene()
    {
        StartCoroutine(DiceRoll());
        //SESc.PlaydiceSE();
        //SceneManager.LoadScene("DiceScene");
    }

    IEnumerator DiceRoll()
    {
        SESc.PlaydiceSE();
        yield return new WaitForSeconds(SESc.dice_SE.length);
        SceneManager.LoadScene("DiceScene");
    }
}
