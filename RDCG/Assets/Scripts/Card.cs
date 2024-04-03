using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class Card 

{
    //Get Set 프로퍼티 (개방폐쇄형)
    public string cardName { get; private set; } //카드의 이름을 저장하는 변수
    public int cardCost { get; private set; } //카드의 코스트를 저장하는 변수
    public int cardValue { get; private set; } //카드의 데미지나 방어를 저장하는 능력치 변수
    public string cardContent { get; private set; } //카드의 정보를 설명하는 변수

    //생성자
    public Card(string name, int cost, int value, string content)
    {
        this.cardName = name; // 카드 이름 초기화
        this.cardCost = cost; // 카드 코스트 초기화
        this.cardValue = value; // 카드 벨류 초기화
        this.cardContent = content; // 카드 내용 초기화
    }
}