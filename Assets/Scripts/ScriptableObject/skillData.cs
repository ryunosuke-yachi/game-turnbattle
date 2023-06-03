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

    public string Name; //�X�L����
    public int MP;//�K�vMP
    public string Effect;//�X�L������
    public int skillGroup;//0 = �U��, 1 = �h��, 2 = �A�C�e��
    public int turnLimit;//�^�[������
    public bool isSelect;//�I������Ă��邩
    public bool inEffect;//�X�L�����ʒ���
    public int image;//�X�L���C���X�g

}
