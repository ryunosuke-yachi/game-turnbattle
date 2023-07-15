using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class skillData : ScriptableObject
{
    public List<skillInfo> skillInfoList = new List<skillInfo>();
    public List<skillButton> skillButtons = new List<skillButton>();
}

[System.Serializable]
public class skillInfo
{

    public string Name; //スキル名
    public int MP;//必要MP
    public string Effect;//スキル効果
    public int skillGroup;//0 = 攻撃, 1 = 防御, 2 = アイテム
    public int turnLimit = 0;//ターン制限
    public bool isSelect;//選択されているか
    public int image;//スキルイラスト
    public bool isUsed;

}

public class skillButton
{
    public int skillID; // スキルの種類(skillInfoList[n]の[]の中のnに入れる番号)
    public bool isSelect; // skillInfoの中にあった、isSelect
}
