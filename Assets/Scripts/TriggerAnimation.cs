using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    [SerializeField] Animator mainCharaAnim;//���C���L�����̃A�j���[�^�[
    [SerializeField] Animator cameraAnim;//�J�����̃A�j���[�^�[
    [SerializeField] Animator enemyAnim;//�G�̃A�j���[�^�[

    public bool playerAnimationPlaying = false;
    public bool enemyAnimationPlaying = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator WaitForAnimation(string animationName)//animetion�I���܂Ŏ��̏�����҂R���[�`��
    {

        
        mainCharaAnim.SetTrigger(animationName);
        while(IsAnimationPlaying())
        {
            while (!mainCharaAnim.GetCurrentAnimatorStateInfo(0).IsName(animationName))
            {
                //Debug.Log("test");
                yield return null;
            }

            while (mainCharaAnim.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
            {
                //Debug.Log("test2");
                yield return null;
            }
            playerAnimationPlaying = false;
            Debug.Log("animation Finished");

        }


    }

    IEnumerator WaitForEnemyAnimation(string animationName)
    {
        enemyAnim.SetTrigger(animationName);
        while(IsEnemyAnimationPlaying())
        {
            while (!enemyAnim.GetCurrentAnimatorStateInfo(0).IsName(animationName))
            {
                yield return null;
            }

            while(enemyAnim.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
            {
                yield return null;
            }
            enemyAnimationPlaying = false;
            Debug.Log("enemyAnimation Finished");
        }

    }
    public void TriggerPlayerAnimation (string animationName)//player��SingleAttack�A�j���[�V�����Đ�
    {
        playerAnimationPlaying = true;
        StartCoroutine(WaitForAnimation(animationName));

    }

    public void TriggerEnemyAnimation(string animationName)
    {
        enemyAnimationPlaying = true;
        StartCoroutine(WaitForEnemyAnimation(animationName));
    }
    public bool IsAnimationPlaying()
    {
        return playerAnimationPlaying;
    }

    public bool IsEnemyAnimationPlaying()
    {
        return enemyAnimationPlaying;
    }
}
