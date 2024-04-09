using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo : MonoBehaviour
{
    // 카드의 속성을 설정할 Card 컴포넌트
    private Card cardComponent;
    // 카드의 이름
    public string cardName;
    // 카드의 코스트
    public int cardCost;
    // 카드의 값
    public int cardValue;
    // 카드의 내용
    public string cardContent;
    // 카드의 특수효과
    public int cardEffect;

    // Start is called before the first frame update
    void Start()
    {
        // Card 클래스의 생성자를 사용하여 카드 생성 및 속성 설정
        Card cardComponent = new Card(cardName, cardCost, cardValue, cardContent);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
