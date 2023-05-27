using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Re : MonoBehaviour
{
    [SerializeField] private GameObject[] initialButtons;  // 初期の3つのボタン
    [SerializeField] private GameObject[] newButtons;      // 切り替え後の5つのボタン

    private void Start()
    {
        SetActiveButtons(initialButtons);
    }

    private void SetActiveButtons(GameObject[] buttons, bool active = true)
    {
        foreach (var button in buttons)
        {
            button.SetActive(active);
        }
    }


    public void OnClick()
    {
        SetActiveButtons(newButtons, false);
        SetActiveButtons(initialButtons);
    }
}
