using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public int enemyHp; // 적의 현재 체력
    public int enemyMaxHp; // 적의 최대 체력
    public Text enemyHpText; // 적의 체력을 알 수 있는 체력 텍스트
    public int enemyRandomDamage; // 적이 플레이어에게 줄 수 있는 랜덤 데미지 (적의 행동 패턴을 다양하게)

    public bool isEnemyDead; // 적이 죽었는지 살았는지 상태

    // Start is called before the first frame update
    void Start()
    {
        enemyHp = 100;
        enemyMaxHp = 100;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnemyAttack()
    {
        if (!isEnemyDead)
        {
            
        }
    }
}
