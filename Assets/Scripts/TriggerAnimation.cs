using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    [SerializeField] Animator mainCharaAnim;//メインキャラのアニメーター
    [SerializeField] Animator cameraAnim;//カメラのアニメーター
    [SerializeField] Animator enemyAnim;//敵のアニメーター

    private bool animationPlaying = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator WaitForAnimation(string animationName)//animetion終了まで次の処理を待つコルーチン
    {

        if(animationPlaying)
        {
            mainCharaAnim.SetTrigger(animationName);

            while (!mainCharaAnim.GetCurrentAnimatorStateInfo(0).IsName(animationName))
            {
                Debug.Log("test");
                yield return null;
            }

            while (mainCharaAnim.GetCurrentAnimatorStateInfo(0).normalizedTime < 0.8f)
            {
                Debug.Log("test2");
                yield return null;
            }

            animationPlaying = false;
            Debug.Log("animation Finished");
        }

    }
    public void TriggerPlayerAnimation (string animationName)//playerのSingleAttackアニメーション再生
    {
        StartCoroutine(WaitForAnimation(animationName));
        animationPlaying = true;

    }

    public bool IsAnimationPlaying()
    {
        {
            return animationPlaying;
        } 
    }
}
