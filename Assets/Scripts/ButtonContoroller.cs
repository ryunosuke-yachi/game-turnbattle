using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonContoroller : MonoBehaviour
{
    [SerializeField] private GameObject[] initialButtons;   // �����\����3�̃{�^��
    [SerializeField] private GameObject[] attackButtons;    // Attack�{�^���ɑΉ�����X�L���{�^��
    [SerializeField] private GameObject[] defenseButtons;   // Defense�{�^���ɑΉ�����X�L���{�^��
    [SerializeField] private GameObject[] itemButtons;      // Item�{�^���ɑΉ�����X�L���{�^��

    public void OnClickAttackButton()
    {
        SetActiveButtons(initialButtons, false);
        SetActiveButtons(attackButtons, true);
    }

    public void OnClickDefenseButton()
    {
        SetActiveButtons(initialButtons, false);
        SetActiveButtons(defenseButtons, true);
    }

    public void OnClickItemButton()
    {
        SetActiveButtons(initialButtons, false);
        SetActiveButtons(itemButtons, true);
    }

    private void SetActiveButtons(GameObject[] buttons, bool active)
    {
        foreach (var button in buttons)
        {
            button.SetActive(active);
        }
    }

    private void Start()
    {
        SetActiveButtons(initialButtons, true);
        SetActiveButtons(attackButtons, false);
        SetActiveButtons(defenseButtons, false);
        SetActiveButtons(itemButtons, false);
    }
}
