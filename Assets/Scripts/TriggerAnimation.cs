using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    [SerializeField] Animator mainCharaAnim;//���C���L�����̃A�j���[�^�[
    [SerializeField] Animator cameraAnim;//�J�����̃A�j���[�^�[
    [SerializeField] Animator enemyAnim;//�G�̃A�j���[�^�[

    public bool animationPlaying = false;
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
            animationPlaying = false;
            Debug.Log("animation Finished");

        }


    }
    public void TriggerPlayerAnimation (string animationName)//player��SingleAttack�A�j���[�V�����Đ�
    {
        animationPlaying = true;
        StartCoroutine(WaitForAnimation(animationName));

    }

    public bool IsAnimationPlaying()
    {
        return animationPlaying;
    }
}