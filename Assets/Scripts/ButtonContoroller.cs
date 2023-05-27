using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonContoroller : MonoBehaviour
{
    [SerializeField] private GameObject[] initialButtons;   // 初期表示の3つのボタン
    [SerializeField] private GameObject[] attackButtons;    // Attackボタンに対応するスキルボタン
    [SerializeField] private GameObject[] defenseButtons;   // Defenseボタンに対応するスキルボタン
    [SerializeField] private GameObject[] itemButtons;      // Itemボタンに対応するスキルボタン

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
