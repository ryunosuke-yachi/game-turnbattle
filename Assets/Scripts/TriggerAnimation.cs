using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    [SerializeField] Animator mainCharaAnim;//���C���L�����̃A�j���[�^�[
    [SerializeField] Animator cameraAnim;//�J�����̃A�j���[�^�[
    [SerializeField] Animator enemyAnim;//�G�̃A�j���[�^�[
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator WaitForAnimation()//animetion�I���܂Ŏ��̏�����҂R���[�`��
    {
        while(mainCharaAnim.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
        {
            yield return null;
        }

        StopCoroutine(WaitForAnimation());
        Debug.Log("animation Finished");
    }
    public void TriggerSingleAttack()//player��SingleAttack�A�j���[�V�����Đ�
    {
        mainCharaAnim.SetTrigger("singleAttack");
        StartCoroutine(WaitForAnimation());
    }

    public void TriggerDoubleAttack()//player��doubleAttack�A�j���[�V�����Đ�
    {
        mainCharaAnim.SetTrigger("doubleAttack");
        StartCoroutine(WaitForAnimation());
    }

    public void TriggerThirdAttack()//player��3�Ԗڂ̍U���A�j���[�V�����Đ�
    {
        mainCharaAnim.SetTrigger("thirdAttack");
        StartCoroutine(WaitForAnimation());
    }

    public void TriggerFourthAttack()//player��4�Ԗڂ̍U���A�j���[�V�����Đ�
    {
        mainCharaAnim.SetTrigger("fourthAttack");
        StartCoroutine(WaitForAnimation());
    }

    public void TriggerFifthAttack()//player��5�Ԗڂ̍U���A�j���[�V�����Đ�
    {
        mainCharaAnim.SetTrigger("fifthAttack");
        StartCoroutine(WaitForAnimation());
    }

    public void TriggerGuard()//player�̃K�[�h�A�j���[�V�����Đ�
    {
        mainCharaAnim.SetTrigger("guard");
        StartCoroutine(WaitForAnimation());
    }

    public void TriggerDiceSkill()//pleyer�̃_�C�X�X�L���A�j���[�V�����Đ�
    {
        mainCharaAnim.SetTrigger("diceSkill");
        StartCoroutine(WaitForAnimation());
    }
}
