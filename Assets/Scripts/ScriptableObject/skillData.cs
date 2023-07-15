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

    public string Name; //�X�L����
    public int MP;//�K�vMP
    public string Effect;//�X�L������
    public int skillGroup;//0 = �U��, 1 = �h��, 2 = �A�C�e��
    public int turnLimit = 0;//�^�[������
    public bool isSelect;//�I������Ă��邩
    public int image;//�X�L���C���X�g
    public bool isUsed;

}

public class skillButton
{
    public int skillID; // �X�L���̎��(skillInfoList[n]��[]�̒���n�ɓ����ԍ�)
    public bool isSelect; // skillInfo�̒��ɂ������AisSelect
}
