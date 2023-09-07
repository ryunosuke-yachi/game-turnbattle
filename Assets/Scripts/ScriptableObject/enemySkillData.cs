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


    public string name;//�X�L����
    public int minMP;//�ŏ�MP
    public int maxMP;//�ő�MP
    public string Effect;//�X�L������
    public int gauge;//���߂�Q�[�W�̗�
    public int image;//�X�L���C���X�g
    public int currentSkill; //�ǂ̃X�L�����g�����̔ԍ�

}