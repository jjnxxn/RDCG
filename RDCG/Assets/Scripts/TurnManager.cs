using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnManager : MonoBehaviour
{
    public Button turnBtn; // 턴종료 버튼 누르면 적의 턴으로 넘어가는 UI
    public bool isPlayerTurn = false; // 현재 플레이어의 턴상태 확인
    public bool isEnemyTurn = false; // 현재 적의 턴상태 확인

    Player player; // 플레이어 스크립트를 불러옴
    Enemy enemy; // 적 스크립트를 불러옴
    
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Player>();
        enemy = GetComponent<Enemy>();
        turnBtn = GetComponent<Button>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TurnButton()
    {

    }
    public void PlayerAttack()
    {

    }
    /// <summary>
    /// 플레이어가 죽지 않았다면 PlayerTurn() 함수를 실행
    /// 현재 플레이어의 턴에 코스트를 얻는 PlayerGetCost()를 사용
    /// 플레이어는 자신 턴 때 카드를 사용하며 데미지를 주는 PlayerAttack()를 사용
    /// </summary>
    public void PlayerTurn()
    {

    }

    public void EnemyTurn()
    {
        
    }
}
