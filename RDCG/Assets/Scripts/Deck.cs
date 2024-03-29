using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck : MonoBehaviour
{
    // 카드를 담는 리스트를 선언
    public List<Card> cardDeck = new List<Card>();

    /// <summary>
    /// 카드를 추가하는 함수 나중에 CSV로 데이터를 불러 받아서 기능 구현이 되면 수정 할 예정
    /// 총 덱은 10장이 있는데 5장은 1데미지 1코스트, 3장은 2데미지 2코스트, 2장은 3데미지 3코스트
    /// 나중에 new Card 할 때 Attack 인지 Defense 일지 CardType를 정해주는 것을 Enum 클래스로 타입을 정함
    /// </summary>
    public void CardAdd()
    {
        cardDeck.Add(new Card("카드1", 1, 1, "적에게 데미지 1를 줍니다."));
        cardDeck.Add(new Card("카드 2", 1, 1, "적에게 데미지 1를 줍니다."));
        cardDeck.Add(new Card("카드 3", 1, 1, "적에게 데미지 1를 줍니다."));
        cardDeck.Add(new Card("카드 4", 1, 1, "적에게 데미지 1를 줍니다."));
        cardDeck.Add(new Card("카드 5", 1, 1, "적에게 데미지 1를 줍니다."));
        cardDeck.Add(new Card("카드 6", 2, 2, "적에게 데미지 2를 줍니다."));
        cardDeck.Add(new Card("카드 7", 2, 2, "적에게 데미지 2를 줍니다."));
        cardDeck.Add(new Card("카드 8", 2, 2, "적에게 데미지 2를 줍니다."));
        cardDeck.Add(new Card("카드 9", 3, 3, "적에게 데미지 3를 줍니다."));
        cardDeck.Add(new Card("카드 10", 3, 3, "적에게 데미지 3를 줍니다."));
    }
}