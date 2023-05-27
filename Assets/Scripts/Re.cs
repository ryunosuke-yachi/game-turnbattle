using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Re : MonoBehaviour
{
    [SerializeField] private GameObject[] initialButtons;  // ������3�̃{�^��
    [SerializeField] private GameObject[] newButtons;      // �؂�ւ����5�̃{�^��

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
