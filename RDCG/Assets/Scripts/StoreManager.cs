using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StoreManager : MonoBehaviour
{
    private int playerMoney; // 현재 플레이어가 소유하고 있는 돈
    private float playerHp; // 플레이어가 가지고 있는 현재 HP
    private const int maxPlayerHp = 100; // 플레이어가 가지고 있는 최대 HP
    public Text playerMoneyText; // 플레이어가 현재 가지고 있는 돈을 나타내는 Text
    public Text playerHpText; // 플레이어가 현재 가지고 있는 체력을 나타내는 Text
    private int hpRecoveryCost = 200; // 체력을 회복하는데 필요한 비용
    private int hpRecoveryAmount = 20; // 체력을 회복하는 양
    private int cardRecoverCost = 200; // 카드 사는데 필요한 비용

    public Deck deck; // Deck 스크립트에 대한 참조 추가

    // Start is called before the first frame update
    void Start()
    {
         //현재 플레이어가 소유하고 있는 돈 받아오기
         playerMoney = Player.GetPlayerMoney(); 
         //현재 플레이어가 가지고 있는 HP 받아오기
         playerHp = Player.GetPlayerHp(); 
        
        //테스트를 위해서 임시값 넣었음
        //playerMoney = 1200;
        //playerHp = 20;
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
        SceneManager.LoadScene("Stage");
    }

    /// <summary>
    /// 플레이어의 체력을 회복하고 돈을 소모하는 함수
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
            Player.SetPlayerMoney(playerMoney); // 플레이어스크립트의 돈을 최신화
            Player.SetPlayerHp(playerHp);  // 플레이어의 스크립트의 체력을 최신화
        }
        else
        {
            Debug.Log("현재 플레이어는 체력을 살 수 없습니다.");
        }
    }

    /// <summary>
    /// 카드를 구매하는 함수
    /// </summary>
    public void BuyCardButton()
    {
        // 가진돈이 전체 카드 구매 비용보단 많을경우 
        if(playerMoney >= cardRecoverCost)
        {
            playerMoney -= cardRecoverCost; //돈을 카드비용만큼 줄임
            Player.SetPlayerMoney(playerMoney); // 플레이어스크립트의 돈을 최신화

            // 현재덱에 랜덤 카드 추가
            deck.AddRandomCardToDeck();
        }
        else
        {
            Debug.Log("돈이 부족합니다.");
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