using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int playerHp = 100; // 플레이어의 현재 체력
    public int playerMaxHp; // 플레이어의 최대 체력
    public int playerCost = 1; // 플레이어의 현재 사용 할 수 있는 코스트
    public int playerMaxCost = 10; //  플레이어의 최대 코스트

    public Text playerHpText; // 플레이어의 체력을 나타내는 텍스트 UI
    public Text playerCostText; // 플레이어의 코스트를 나타내는 텍스트 UI

    public int cardCost; // 카드가 가지고 있는 코스트
    public int cardValue;  // 카드가 가지고 있는 값 (데미지나 방어 등)

    public bool isPlayerDead = false; // 플레이어가 죽었는지 살아있는지 상태

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// 플레이어가 턴마다 코스트를 얻는 것을 구현
    /// </summary> 

    public void PlayerGetCost()
    {
        if (playerCost != playerMaxCost) // 만약 플레이어의 코스트가 플레이어의 최대 코스트가 아니면
        {
            playerCost++; // 플레이어의 코스트는 하나씩 증가시킨다.
        }
    }
    /// <summary>
    /// 현재 플레이어가 죽는 상태를 나타내는 함수
    /// 플레이어의 체력이 0 이하 일 경우 isPlayerDead true
    /// 플레이어의 체력이 0 보다 많을 경우 isPlayerDead false
    /// </summary>
    public void PlayerDead()
    {
        if (playerHp <= 0)
        {
            isPlayerDead = true;
        }
        else
        {
            isPlayerDead = false;
        }
    }
}
