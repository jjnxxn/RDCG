using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StoreManager : MonoBehaviour
{
    private int playerMoney; // 현재 플레이어가 소유하고 있는 돈
    private int playerHp; // 플레이어가 가지고 있는 현재 HP
    private const int maxPlayerHp = 100; // 플레이어가 가지고 있는 최대 HP
    public Text playerMoneyText; // 플레이어가 현재 가지고 있는 돈을 나타내는 Text
    public Text playerHpText; // 플레이어가 현재 가지고 있는 체력을 나타내는 Text
    private int hpRecoveryCost = 200; // 체력을 회복하는데 필요한 비용
    private int hpRecoveryAmount = 20; // 체력을 회복하는 양

    // Start is called before the first frame update
    void Start()
    {
        playerMoney = 1100; // 현재 플레이어가 소유하고 있는 돈
        playerHp = 30; // 현재 플레이어가 가지고 있는 HP
    }

    // Update is called once per frame
    void Update()
    {
        UpdatePlayerText(); // 현재 플레이어가 가지고 있는 돈과 체력을 텍스트 UI로 표현
    }

    /// <summary>
    /// 뒤로가기 버튼: Stage 선택씬으로 이동
    /// </summary>
    public void BackButton()
    {
        SceneManager.LoadScene("MainTitle");
    }

    /// <summary>
    /// 플레이어의 체력을 회복하고 돈을 소모하는 함수
    /// 나중에 Player 데이터를 받아서 클래스로 수정할 예정
    /// </summary>
    public void PlayerHPBuyButton()
    {
        if (playerHp == maxPlayerHp)
        {
            Debug.Log("플레이어의 체력이 최대입니다.");
        }
        else if (playerHp < maxPlayerHp && playerMoney >= hpRecoveryCost)
        {
            playerMoney -= hpRecoveryCost;
            playerHp = Mathf.Min(playerHp + hpRecoveryAmount, maxPlayerHp);
            Debug.Log("플레이어의 돈: " + playerMoney);
            Debug.Log("플레이어의 체력: " + playerHp);
        }
        else
        {
            Debug.Log("현재 플레이어는 체력을 살 수 없습니다.");
        }
    }

    /// <summary>
    /// 카드를 구매하는 함수
    /// 나중에 Card 리스트를 받아서 배열로 몇 번째를 할당하고 랜덤적으로 가중치 부여해서 구매 할 예정
    /// </summary>
    public void BuyCardButton()
    {
        int cardRandomType = Random.Range(1, 4);

        switch (cardRandomType)
        {
            case 1:
                Debug.Log("너는 카드 1을 샀어");
                break;
            case 2:
                Debug.Log("너는 카드 2을 샀어");
                break;
            case 3:
                Debug.Log("너는 카드 3을 샀어");
                break;
            default:
                Debug.Log("카드 타입이 존재하지 않습니다.");
                break;
        }
    }

    /// <summary>
    /// 플레이어의 돈과 체력을 Text UI로 업데이트하는 함수
    /// 보여주기 용도
    /// </summary>
    private void UpdatePlayerText()
    {
        playerMoneyText.text = "Money: " + playerMoney.ToString();
        playerHpText.text = "HP: " + playerHp.ToString();
    }
}