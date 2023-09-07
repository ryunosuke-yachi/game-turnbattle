using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class EnemyStatus : ScriptableObject
{

    public int HP;//�G��HP
    public int MP;//�G��MP
    public int gauge;//�G�̃Q�[�W��
    public List<int> diceList;
    public int diceSituation;//�ǂ̃_�C�X���ӂ邩
    public int increaseGauge = 20;//���̍s���ő�����Q�[�W�̗�
    public int maxGauge = 100;//�Q�[�W��max��
    public bool isDead;
    public int currentSkill; //�ǂ̃X�L�����g�����̔ԍ�
}
