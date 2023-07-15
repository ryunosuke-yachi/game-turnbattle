using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class dice : MonoBehaviour
{
    private Rigidbody rb;
    public int diceNum;//ダイスの出目
    Vector3 rot;//ダイスを振るときのrotitation
    [Header("forceの大きさ")]
    [SerializeField] private float force = 100.0f;
    Vector3 forceDir;//力を加える向き
    GameObject[] playerDice; //playerDiceタグのオブジェクト配列
    GameObject[] enemyDice;//enemyDiceタグのオブジェクト配列
    [SerializeField] PlayerStatus playerStatus;
    [SerializeField] EnemyStatus enemyStatus;
    bool isCalled; //目を出すスクリプトが呼ばれたか
    float LimitTime;//重力を強める時間
    Vector3 startPos;//振る前の座標
    GameObject normalDice;
    GameObject lowDice;
    GameObject highDice;
    // Start is called before the first frame update
    void Start()
    {
        playerStatus.MP = 0;
        enemyStatus.MP = 0;
        startPos = this.transform.position;
        forceDir = new Vector3(0, -1.0f, 2.0f);
        rb = GetComponent<Rigidbody>();
        rot = new Vector3(Random.Range(0, 360), Random.Range(0, 360), Random.Range(0, 360));
        transform.Rotate(rot);
        rb.AddForce(transform.forward * force, ForceMode.Impulse);
        isCalled = false;
        LimitTime = 3.0f;
        playerStatus.diceList = new List<int>();
    }

    // Update is called once per frame
    
    void Update()
    {
        LimitTime -= Time.deltaTime;
        if (LimitTime > 0)
        {
            rb.AddForce(1.5f * Physics.gravity, ForceMode.Acceleration);
        }
        onGround();
    }

    void onGround()
    {
        if (rb.IsSleeping() && !isCalled)
        {
            isCalled = true;
            diceNum = getNumber(gameObject.transform);
            addMP();
        }
        if (playerStatus.diceList.Count > 9)
        {
            displayDice();
            isCalled = false;
        }

    }
    public int getNumber(Transform diceTransform)
    {
        float X = Vector3.Dot(diceTransform.right, Vector3.up);//X軸方向との内積
        float Y = Vector3.Dot(diceTransform.up, Vector3.up);//Y軸方向との内積
        float Z = Vector3.Dot(diceTransform.forward, Vector3.up);//Z軸方向との内積
        if(gameObject.tag == "playerDice" || gameObject.tag == "enemyDice")
        {
            if (Mathf.Abs(X) > Mathf.Abs(Y) && Mathf.Abs(X) > Mathf.Abs(Z))//X軸が一番upベクトルに近い
            {
                if (X > 0.0f)//符号で出目を決定
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
            else if (Mathf.Abs(Y) > Mathf.Abs(X) && Mathf.Abs(Y) > Mathf.Abs(Z))//Y軸が一番近い
            {
                if (Y > 0.0f)
                {
                    return 6;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                if (Z > 0.0f)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
             } 
         }else if(gameObject.tag == "456Dice")
        {
            if (Mathf.Abs(X) > Mathf.Abs(Y) && Mathf.Abs(X) > Mathf.Abs(Z))//X軸が一番upベクトルに近い
            {
                if (X > 0.0f)//符号で出目を決定
                {
                    return 5;
                }
                else
                {
                    return 5;
                }
            }
            else if (Mathf.Abs(Y) > Mathf.Abs(X) && Mathf.Abs(Y) > Mathf.Abs(Z))//Y軸が一番近い
            {
                if (Y > 0.0f)
                {
                    return 6;
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
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
        else
        {
            if (Mathf.Abs(X) > Mathf.Abs(Y) && Mathf.Abs(X) > Mathf.Abs(Z))//X軸が一番upベクトルに近い
            {
                if (X > 0.0f)//符号で出目を決定
                {
                    return 2;
                }
                else
                {
                    return 2;
                }
            }
            else if (Mathf.Abs(Y) > Mathf.Abs(X) && Mathf.Abs(Y) > Mathf.Abs(Z))//Y軸が一番近い
            {
                if (Y > 0.0f)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                if (Z > 0.0f)
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }
    }

    void addMP()
    {
        if(gameObject.tag == "playerDice" || gameObject.tag == "456Dice")
        {
            playerStatus.MP += diceNum;
            LimitTime = 3.0f;
            playerStatus.diceList.Add(diceNum);
            Debug.Log("playerMP:" + playerStatus.MP);
        }
        else if(gameObject.tag == "enemyDice" || gameObject.tag == "123Dice")
        {
            enemyStatus.MP += diceNum;
            LimitTime = 3.0f;
            playerStatus.diceList.Add(diceNum);
            Debug.Log("enemyMP:" + enemyStatus.MP);
        }
    }

    void displayDice()
    {
        transform.position = startPos;
        switch (diceNum)
        {
            case 1:
                transform.rotation = Quaternion.Euler(0, 0, -90);
                break;
            case 2:
                transform.rotation = Quaternion.Euler(-90, 0, 0);
                break;
            case 3:
                transform.rotation = Quaternion.Euler(0, 0, 0);
                break;
            case 4:
                transform.rotation = Quaternion.Euler(-180, 0, 0);
                break;
            case 5:
                transform.rotation = Quaternion.Euler(90, 0, 0);
                break;
            case 6:
                transform.rotation = Quaternion.Euler(0, 0, 90);
                break;
        }
        rb.constraints = RigidbodyConstraints.FreezeAll;
    }
}
