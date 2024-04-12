using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float enemyHp; // 적의 현재 체력
    public float enemyMaxHp; // 적의 최대 체력

    public Text enemyHpText; // 적의 체력을 알 수 있는 체력 텍스트
    public Slider enemyHpBar; // 현재 적의 체력 바 UI 
    public Animation enemyWarning; //적이 강력한 공격을 하는 애니메이션
    public Text enemyWarningText; // 적이 강력한 공격을 할 때 나오는 텍스트

    public int enemyAttackDamage; // 적이 플레이어에게 줄 수 있는 데미지
    public int enemyRandomDamage; // 적이 플레이어에게 줄 수 있는 랜덤 데미지 (적의 행동 패턴을 다양하게)

    public Player player; // 플레이어 스크립트

    public bool isEnemyDead; // 적이 죽었는지 살았는지 상태

    // Start is called before the first frame update
    void Start()
    {
        enemyMaxHp = 30;
        enemyWarningText.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        enemyHpText.text = "HP : " + enemyHp.ToString();
        enemyHpBar.value = enemyHp / enemyMaxHp; // HP 슬라이더 바 현재 체력 비례하여 최대 체력으로 나눠 업데이트
    }

    /// <summary>
    /// 적이 플레이어의 체력을 1부터 10으로 랜덤하게 데미지를 주는 함수
    /// </summary>
    public void EnemyAttack()
    {
        enemyRandomDamage = Random.Range(1, 11); // 적은 플레이어의 체력을 랜덤적으로 1~10까지 까이게 함
        player.playerHp -= enemyRandomDamage; // 플레이어의 체력을 적의 랜덤 데미지만큼 까이게 함
        Debug.Log("플레이어의 현재 체력은 " + player.playerHp);
    }

    /// <summary>
    /// 적이 5턴일 경우 현재 체력에서 최대 체력 절반만큼 차게 하는 함수
    /// </summary>
    public void EnemyHeal()
    {
        Debug.Log("적의 체력이 회복되었습니다.");
        enemyHp += enemyMaxHp;

        if (enemyHp >= enemyMaxHp)
        {
            enemyHp = enemyMaxHp;
        }
    }

    /// <summary>
    /// 적의 턴이 10턴이 되었을 경우 플레이어에게 강력한 공격을 한번 주는 함수
    /// </summary>
    public void EnemyLastAttack()
    {
        enemyAttackDamage = 30; // 강력한 공격은 30 데미지
        player.playerHp -= enemyAttackDamage; // 플레이어 체력을 30만큼 까이게 함
        Debug.Log("플레이어의 현재 체력은 " + player.playerHp);
    }

    /// <summary>
    /// 적이 강력한 공격을 할 때 나오는 경고창 UI 패널로 나옴
    /// </summary>
    public IEnumerator EnemyWarning()
    {
        enemyWarningText.enabled = true; // 경고 메세지 보이게 함
        enemyWarningText.text = "적이 강력한 공격을 \n준비중입니다...";
        enemyWarning.Play(); // 적 경고 애니메이션 실행

        yield return new WaitForSeconds(1.0f); // 1초 대기 후

        enemyWarningText.enabled = false; // 경고 메세지 사라지게 실행
    }
}
