using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float enemyHp = 30; // 적의 현재 체력
    public float enemyMaxHp = 30; // 적의 최대 체력
    public Text enemyHpText; // 적의 체력을 알 수 있는 체력 텍스트
    public Slider enemyHpBar; // 현재 적의 체력 바 UI 
    public int enemyRandomDamage; // 적이 플레이어에게 줄 수 있는 랜덤 데미지 (적의 행동 패턴을 다양하게)

    public Player player; // 플레이어 스크립트

    public bool isEnemyDead; // 적이 죽었는지 살았는지 상태

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemyHpText.text = "HP : " + enemyHp.ToString();
        enemyHpBar.value = enemyHp / enemyMaxHp; // HP 슬라이더 바 현재 체력 비례하여 최대 체력으로 나눠 업데이트
    }

    public void EnemyAttack()
    {
        enemyRandomDamage = Random.Range(1, 11); // 에너미는 플레이어의 체력을 랜덤적으로 1~10까지 까이게 함
        player.playerHp -= enemyRandomDamage;
        Debug.Log("플레이어의 현재 체력은 " + player.playerHp);
    }
}
