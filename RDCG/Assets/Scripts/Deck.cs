using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 추가적으로 얻을수있는 카드 관리하는 스크립트
public class Deck : MonoBehaviour
{
    // 덱에 추가할수있는 카드를 담는 리스트를 선언
    public List<GameObject> cardList = new List<GameObject>();

    private void Update()
    {
        // 테스트 위해서 키보드6번 누를시 카드가 생성되도록 만듬
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            // 현재 씬에서 사용되는 카드 덱을 관리하는 CurrentDeck 스크립트를 찾아 변수에 할당
            CurrentDeck currentDeck = FindObjectOfType<CurrentDeck>();

            // 현재 카드 덱 리스트를 함수의 매개변수로 전달하여 카드 추가
            AddRandomCardToDeck(currentDeck.cardDeck);
        }
    }

    // 현재 스테이지에서 사용할 카드를 담아놓은 덱에 랜덤 카드 추가하는 함수
    public void AddRandomCardToDeck(List<GameObject> deck)
    {
        // 리스트 내에 랜덤 인덱스 선택
        int randomIndex = Random.Range(0, cardList.Count);

        // 선택된 카드를 현재 덱에 추가
        deck.Add(cardList[randomIndex]);
    }
}
