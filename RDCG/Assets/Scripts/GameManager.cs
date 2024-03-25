using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    
    //선택한 카드를 넣을 변수
    private GameObject Card;
    
    //카드 선택시 함수
    public void ClickCard()
    {//클릭한 오브젝트의 이름을 string변수가 저장
        string cardName = EventSystem.current.currentSelectedGameObject.name;
        //마나가 없으면 카드 사용이 안되고 마나 없다고 안내창 뜸
        if (this.GetComponent<Player>().AP == 0)
        {
            Debug.Log("마나가 없습니다!");
        }
        else
        {//데미지 입었다는 디버그
        Debug.Log("데미지 10의 카드를 사용하였습니다.");
            this.GetComponent<Player>().ManaConsumption();
        //클릭한 카드 이름을 변수에 저장
        Card = GameObject.Find(cardName);
        //선택 카드 삭제
        Destroy(Card);

        }
    }
    //턴 종료 함수
    public void ClickEnd()
    {//데미지를 입었다는 디버그
        Debug.Log("데미지 10을 입었습니다");
        //적이 공격하여 데미지를 입은 함수
        this.GetComponent<Player>().PlayerDamage();
        //적이 공격 후 턴이 종료 되면서 내 턴이 와서 마나를 얻는 함수
        this.GetComponent<Player>().MyTurn();
        //마나와 피 UI업데이트
        this.GetComponent<Player>().UpdateState();

        

    }
    


}
