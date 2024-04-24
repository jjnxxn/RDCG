using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentDeck : MonoBehaviour
{
    // 카드덱을 담는 리스트를 선언
    public List<GameObject> cardDeck = new List<GameObject>();

    // 다음 씬으로 전환될 때 오브젝트 파괴되지 않도록 설정
    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // 카드를 덱에 추가하는 메서드
    public void Add(GameObject card)
    {
        cardDeck.Add(card);
    }
}
