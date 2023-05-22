using UnityEditor;
using UnityEngine;

public static class skillDataCreator
{

    [MenuItem("Create/skillData")]
    private static void Create() {

        skillData skilldata = ScriptableObject.CreateInstance<skillData>();//ScriptableObjectのインスタンスを作成

        skillInfo skill_1 = new skillInfo();
        skill_1.Name = "シングルアタック";
        skill_1.MP = 3;

        skill_1.isSelect = false;

        skilldata.skillInfoList.Add(skill_1);

        AssetDatabase.CreateAsset(skilldata,"Assets/skillData.asset");
    }
}
