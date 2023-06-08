using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class EnemyStatus : ScriptableObject
{

    public int HP;//�G��HP
    public int MP;//�G��MP
    public int gauge;//�G�̃Q�[�W��
    public int[] damage = new int [2];//�G���^����_���[�W
    public int [] diceNum = new int [5];//�_�C�X�̌�
    public int diceSituation;//�ǂ̃_�C�X���ӂ邩
    public int increaseGauge = 20;//���̍s���ő�����Q�[�W�̗�
    public int maxGauge = 100;//�Q�[�W��max��
}
