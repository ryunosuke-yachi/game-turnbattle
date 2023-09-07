using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class enemySkillData : ScriptableObject
{
    public List<enemySkillInfo> enemySkillInfoList = new List<enemySkillInfo>();
}

[System.Serializable] 
public class enemySkillInfo{


    public string name;//スキル名
    public int minMP;//最小MP
    public int maxMP;//最大MP
    public string Effect;//スキル効果
    public int gauge;//ためるゲージの量
    public int image;//スキルイラスト
    public int currentSkill; //どのスキルを使うかの番号

}