using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    [SerializeField] Animator mainCharaAnim;//メインキャラのアニメーター
    [SerializeField] Animator cameraAnim;//カメラのアニメーター
    [SerializeField] Animator enemyAnim;//敵のアニメーター
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator WaitForAnimation()//animetion終了まで次の処理を待つコルーチン
    {
        while(mainCharaAnim.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
        {
            yield return null;
        }

        StopCoroutine(WaitForAnimation());
        Debug.Log("animation Finished");
    }
    public void TriggerSingleAttack()//playerのSingleAttackアニメーション再生
    {
        mainCharaAnim.SetTrigger("singleAttack");
        StartCoroutine(WaitForAnimation());
    }

    public void TriggerDoubleAttack()//playerのdoubleAttackアニメーション再生
    {
        mainCharaAnim.SetTrigger("doubleAttack");
        StartCoroutine(WaitForAnimation());
    }

    public void TriggerThirdAttack()//playerの3番目の攻撃アニメーション再生
    {
        mainCharaAnim.SetTrigger("thirdAttack");
        StartCoroutine(WaitForAnimation());
    }

    public void TriggerFourthAttack()//playerの4番目の攻撃アニメーション再生
    {
        mainCharaAnim.SetTrigger("fourthAttack");
        StartCoroutine(WaitForAnimation());
    }

    public void TriggerFifthAttack()//playerの5番目の攻撃アニメーション再生
    {
        mainCharaAnim.SetTrigger("fifthAttack");
        StartCoroutine(WaitForAnimation());
    }

    public void TriggerGuard()//playerのガードアニメーション再生
    {
        mainCharaAnim.SetTrigger("guard");
        StartCoroutine(WaitForAnimation());
    }

    public void TriggerDiceSkill()//pleyerのダイススキルアニメーション再生
    {
        mainCharaAnim.SetTrigger("diceSkill");
        StartCoroutine(WaitForAnimation());
    }
}
