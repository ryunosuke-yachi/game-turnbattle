using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;
using UnityEngine.UI;

public class dice : MonoBehaviour
{
    private Rigidbody rb;
    public int diceNum;//�_�C�X�̏o��
    Vector3 rot;//�_�C�X��U��Ƃ���rotitation
    [Header("force�̑傫��")]
    [SerializeField] private float force = 100.0f;
    Vector3 forceDir;//�͂����������
    GameObject[] playerDice; //playerDice�^�O�̃I�u�W�F�N�g�z��
    GameObject[] enemyDice;//enemyDice�^�O�̃I�u�W�F�N�g�z��
    [SerializeField] PlayerStatus playerStatus;
    [SerializeField] EnemyStatus enemyStatus;
    bool isCalled; //�ڂ��o���X�N���v�g���Ă΂ꂽ��
    float LimitTime;//�d�͂����߂鎞��
    Vector3 startPos;//�U��O�̍��W
    bool isSkiped = false;//skip�{�^���������ꂽ��
    [SerializeField] GameObject playerNormal;//�v���C���[�̒ʏ�_�C�X
    [SerializeField] GameObject high;//�v���C���[456�_�C�X
    [SerializeField] GameObject low;//�G123�_�C�X
    [SerializeField] GameObject enemyNormal;//�G�̒ʏ�_�C�X
    [SerializeField] private Camera camera_;//�J�����I�u�W�F�N�g
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
        camera_.orthographicSize = 14.0f;
        playerStatus.diceList = new List<int>();
        enemyStatus.diceList = new List<int>();
        if (playerStatus.diceSituation == 0)
        {
            playerNormal.SetActive(true);
            high.SetActive(false);
        }
        else
        {
            high.SetActive(true);
            playerNormal.SetActive(false);
        }
        if (enemyStatus.diceSituation == 0)
        {
            enemyNormal.SetActive(true);
            low.SetActive(false);
        }
        else
        {
            low.SetActive(true);
            enemyNormal.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -14.0f)
        {
            rb.Sleep();
        }

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
        if ((playerStatus.diceList.Count == 5)&&(enemyStatus.diceList.Count == 5))
        {
            camera_.orthographicSize = 6.0f;
            displayDice();
            isCalled = false;
            if(!isCalled)
            {
                StartCoroutine(ChangeScene());
            }
        }
    }
    public int getNumber(Transform diceTransform)
    {

        float X = Vector3.Dot(diceTransform.right, Vector3.up);//X�������Ƃ̓���
        float Y = Vector3.Dot(diceTransform.up, Vector3.up);//Y�������Ƃ̓���
        float Z = Vector3.Dot(diceTransform.forward, Vector3.up);//Z�������Ƃ̓���
        if(gameObject.tag == "playerDice" || gameObject.tag == "enemyDice")
        {
            if (Mathf.Abs(X) > Mathf.Abs(Y) && Mathf.Abs(X) > Mathf.Abs(Z))//X�������up�x�N�g���ɋ߂�
            {
                if (X > 0.0f)//�����ŏo�ڂ�����
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
            else if (Mathf.Abs(Y) > Mathf.Abs(X) && Mathf.Abs(Y) > Mathf.Abs(Z))//Y������ԋ߂�
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
            if (Mathf.Abs(X) > Mathf.Abs(Y) && Mathf.Abs(X) > Mathf.Abs(Z))//X�������up�x�N�g���ɋ߂�
            {
                if (X > 0.0f)//�����ŏo�ڂ�����
                {
                    return 5;
                }
                else
                {
                    return 5;
                }
            }
            else if (Mathf.Abs(Y) > Mathf.Abs(X) && Mathf.Abs(Y) > Mathf.Abs(Z))//Y������ԋ߂�
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
            if (Mathf.Abs(X) > Mathf.Abs(Y) && Mathf.Abs(X) > Mathf.Abs(Z))//X�������up�x�N�g���ɋ߂�
            {
                if (X > 0.0f)//�����ŏo�ڂ�����
                {
                    return 2;
                }
                else
                {
                    return 2;
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
        Debug.Log(gameObject.name + " addMP");
        if(gameObject.tag == "playerDice" || gameObject.tag == "456Dice")
        {
            playerStatus.MP += diceNum;
            playerStatus.MaxMP += diceNum; 
            LimitTime = 3.0f;
            playerStatus.diceList.Add(diceNum);
            Debug.Log("player�o��:" + diceNum);
        }
        else if(gameObject.tag == "enemyDice" || gameObject.tag == "123Dice")
        {
            enemyStatus.MP += diceNum;
            LimitTime = 3.0f;
            enemyStatus.diceList.Add(diceNum);
            Debug.Log("enemy�o��:" + diceNum);
        }
    }

    void displayDice()
    {

        transform.position = startPos;

        switch (diceNum)
        {
            case 1:
                transform.rotation = Quaternion.Euler(180, 90, 0);
                break;
            case 2:
                transform.rotation = Quaternion.Euler(0, 90, -90);
                break;
            case 3:
                transform.rotation = Quaternion.Euler(-90, 90, 0);
                if (enemyStatus.diceSituation == 1)
                {
                    transform.rotation = Quaternion.Euler(0, 90, 0);
                }
                break;
            case 4:
                transform.rotation = Quaternion.Euler(90, 90, 0);
                if (playerStatus.diceSituation == 1)
                {
                    transform.rotation = Quaternion.Euler(180, 90, 0);
                }
                break;
            case 5:
                transform.rotation = Quaternion.Euler(0, 90, 90);
                break;
            case 6:
                transform.rotation = Quaternion.Euler(0, 90, 0);
                break;
        }




    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(1.5f);
        playerStatus.diceSituation = 0;
        enemyStatus.diceSituation = 0;
        playerStatus.diceList.Clear();
        SceneManager.LoadScene("MainGame");
    }

    public void SkipDiceRoll() 
    {
        
        if(gameObject.tag == "playerDice" || gameObject.tag == "456Dice") {
            playerDiceRoll();
            addMP();
        } else {
            enemyDiceRoll();
            addMP();
        }

        if((playerStatus.diceList.Count == 5) && (enemyStatus.diceList.Count == 5))
        {
            displayDice();
            isCalled = false;
            if(!isCalled) {
                StartCoroutine(ChangeScene());
            }
        }
    }

    void playerDiceRoll() //skip�p��player�o�ڌ���֐�
    {
        switch(playerStatus.diceSituation) 
        {
            case 0:
                diceNum = Random.Range(1,7);
                break;
                case 1:
                diceNum = Random.Range(4,7);
                break;
        }
    }

    void enemyDiceRoll() //skip�p��enemy�o�ڌ���֐�
    {
        switch(enemyStatus.diceSituation) 
        {
            case 0:
                diceNum = Random.Range(1,7);
                break;
                case 1:
                diceNum = Random.Range(1,4);
                break;
        }
    }

    public void skip()
    {
        isSkiped = true;
        if ((!isCalled) && (isSkiped))
        {
            isCalled = true;
            Debug.Log("isCalled" + isCalled);
            Debug.Log("isSkiped" + isSkiped);
            SkipDiceRoll();
        }
    }
}
