using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class dice : MonoBehaviour
{
    private Rigidbody rb;
    public int diceNum;
    Vector3 rot;
    [Header("force�̑傫��")]
    [SerializeField] private float force = 100.0f;
    Vector3 forceDir;//�͂����������
    GameObject[] playerDice; //playerDice�^�O�̃I�u�W�F�N�g�z��
    GameObject[] enemyDice;//enemyDice�^�O�̃I�u�W�F�N�g�z��
    [SerializeField] PlayerStatus playerStatus;
    [SerializeField] EnemyStatus enemyStatus;
    bool isCalled;
    // Start is called before the first frame update
    void Start()
    {
        forceDir = new Vector3(0, -1.0f, 2.0f);
        rb = GetComponent<Rigidbody>();
        rot = new Vector3(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));
        transform.Rotate(rot);
        rb.AddForce((transform.forward) * force, ForceMode.Impulse);
        rb.AddForce(1.5f * Physics.gravity, ForceMode.Acceleration);
        isCalled = false;
    }

    // Update is called once per frame
    
    void Update()
    {
        if(rb.IsSleeping() && !isCalled)
        {
            isCalled = true;
            diceNum = getNumber(gameObject.transform);
            addMP();
            Debug.Log("playerMP:" + playerStatus.MP);
            Debug.Log("enemyMP:" + enemyStatus.MP);

        }
    }

    public int getNumber(Transform diceTransform)
    {
        float X = Vector3.Dot(diceTransform.right, Vector3.up);//X�������Ƃ̓���
        float Y = Vector3.Dot(diceTransform.up, Vector3.up);//Y�������Ƃ̓���
        float Z = Vector3.Dot(diceTransform.forward, Vector3.up);//Z�������Ƃ̓���

        if (Mathf.Abs(X) > Mathf.Abs(Y) && Mathf.Abs(X) > Mathf.Abs(Z))//X�������up�x�N�g���ɋ߂�
        {
            if (X > 0.0f)//�����ŏo�ڂ�����
            {
                return 6;
            }
            else
            {
                return 1;
            }
        }
        else if (Mathf.Abs(Y) > Mathf.Abs(X) && Mathf.Abs(Y) > Mathf.Abs(Z))//Y������ԋ߂�
        {
            if (Y > 0.0f)
            {
                return 3;
            }
            else
            {
                return 4;
            }
        }
        else
        { 
            if (Z > 0.0f)
            {
                return 2;
            }
            else
            {
                return 5;
            }
        }
    }

    public void addMP()
    {
        if(gameObject.tag == "playerDice")
        {
            playerStatus.MP += diceNum;
        }else if(gameObject.tag == "enemyDice")
        {
            enemyStatus.MP += diceNum; 
        }
    }
}
