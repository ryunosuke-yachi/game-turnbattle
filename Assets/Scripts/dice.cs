using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dice : MonoBehaviour
{
    private Rigidbody rb;
    public int diceNum;
    Vector3 rot;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rot = new Vector3(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));
        transform.Rotate(rot);
    }

    // Update is called once per frame
    void Update()
    {
        if(rb.IsSleeping())
        {
            diceNum = getNumber(gameObject.transform);
            Debug.Log(diceNum);
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
}
