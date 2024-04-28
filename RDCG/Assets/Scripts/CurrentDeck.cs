using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentDeck : MonoBehaviour
{
    // 카드덱을 담는 리스트를 선언
    public List<GameObject> cardDeck = new List<GameObject>();

    // 스크립트 인스턴스를 전역에서 접근할 수 있도록 정적 변수로 선언
    public static CurrentDeck instance;


    // 다음 씬으로 전환될 때 오브젝트 파괴되지 않도록 설정
    void Awake()
    {
        // 이미 존재하는 인스턴스가 없다면 현재 인스턴스를 할당하고 씬 전환 시 파괴되지 않도록 설정
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // 카드를 덱에 추가하는 메서드
    public void Add(GameObject card)
    {
        cardDeck.Add(card);
    }

    // 리스트를 초기화하는 메서드
    public void ClearDeck()
    {
        cardDeck.Clear(); // 리스트 내 모든 요소 제거
    }
}
