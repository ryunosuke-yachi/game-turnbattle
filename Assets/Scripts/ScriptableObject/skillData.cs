using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class skillData : ScriptableObject
{
    public List<skillInfo> skillInfoList = new List<skillInfo>(); 
}

[System.Serializable]
public class skillInfo
{

    public string Name; //スキル名
    public int MP;//必要MP
    public string Effect;//スキル効果
    public int skillGroup;//0 = 攻撃, 1 = 防御, 2 = アイテム
    public int turnLimit;//ターン制限
    public bool isSelect;//選択されているか
    public bool inEffect;//スキル効果中か
    public int image;//スキルイラスト

}
