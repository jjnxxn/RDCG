using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnManager : MonoBehaviour
{
    public Button turnBtn; // 턴종료 버튼 누르면 적의 턴으로 넘어가는 UI
    public int enemyTurn; // 적의 턴이 몇번 진행되었는지 알 수 있는 변수
    
    public bool isPlayerTurn; // 현재 플레이어의 턴상태 확인
    public bool isEnemyTurn; // 현재 적의 턴상태 확인

    public Player player; // 플레이어 스크립트를 불러옴
    public Enemy enemy; // 적 스크립트를 불러옴

    // Start is called before the first frame update
    void Start()
    {
        turnBtn.GetComponent<Button>();
        enemyTurn = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }
    /// <summary>
    /// 플레이어 행동을 다 끝내고
    /// 턴 종료 버튼을 눌렀을 경우 적 행동을 실행 시킬 때 비활성화 시키고
    /// 턴 종료 버튼을 다시 활성화
    /// 그 과정에서 플레이어 턴 일 경우 플레이어의 코스트를 매턴 마다 얻는 함수도 실행
    /// </summary>
    public void TurnButtonClick()
    {
        isPlayerTurn = false; // 현재 플레이어 턴을 종료
        isEnemyTurn = true; // 적 턴이 실행

        turnBtn.interactable = false; // 턴 종료 버튼을 비활성화
        enemyTurn++; // 적의 턴 증가 (적의 체력 회복이나 강력한 공격 준비)
        Debug.Log(enemyTurn);
        
        // 적의 턴이 5턴이 진행되었을 경우
        if (enemyTurn == 5)
        {
            enemy.EnemyHeal(); // 적의 체력을 회복하는 함수 실행
        }
        // 적의 턴이 9턴이 진행 되었을 경우
        else if (enemyTurn == 9)
        {
            StartCoroutine(enemy.EnemyWarning()); // 적이 강력한 공격을 할 것이라는 경고 애니메이션 (추후 UI 할 때 수정)
        }
        // 적의 턴이 10턴이 진행 되었을 경우
        else if (enemyTurn == 10)
        {
            enemy.EnemyLastAttack(); // 적이 강력한 공격인 플레이어 체력 30을 깎는 함수 실행
        }

        else
        {
            enemy.EnemyAttack(); // 적 스크립트에 있는 공격 함수 실행
        }

        isPlayerTurn = true; // 플레이어 턴 시작
        isEnemyTurn = false; // 적 턴이 종료

        if (isPlayerTurn == true) // 만약 플레이어 턴이 시작 되면
        {
            player.PlayerGetCost(); // 플레이어의 코스트를 1씩 증가 (최대 코스트까지)
            player.PlayerTurnNewCardSpawn(); // 플레이어의 카드가 새롭게 생성
        }

        turnBtn.interactable = true; // 턴 종료 버튼이 다시 활성화 나중에 코루틴으로 동적 지연을 줄 예정
    }
}
