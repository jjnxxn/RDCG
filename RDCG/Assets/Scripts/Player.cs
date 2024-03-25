using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    //캐릭터 선택에 따른 변수
    private bool Male = false;
    private bool Female = false;
    //플레이어의 체력
    private float HP = 100;
    //턴 마다 얻는 마나?
    public float AP = 1;
    //카드가 없을때 기본 공격력 만큼의 공격카드를 줄때를 위한 변수
    private float AD;
    //HP와 마나 UI 텍스트
    public Text stateText;



    // Start is called before the first frame update
    void Start()
    {//UI 업데이트
        UpdateState();

        //캐릭터에 따른 기본 스탯
        if (Male)
        {
            AD = 20;
            AP = 0;
        }
        else if (Female)
        {
            AD = 10;
            AP = 1;
        }

    }
    // 힐카드를 썼을 때 체력에 따른 결과
    void PlayerHeal()
    {
        if (HP < 100)
            {
                //임의로 10체력회복
                HP += 10;
            }
            else
            {
                //체력이 풀일 경우 힐이 안됨
                Debug.Log("플레이어의 체력이 최대입니다.");
            }
    }


    //플레이어가 공격 당했을 때
    public void PlayerDamage()
    {//임의로 적 공격을 10으로 설정
        HP -= 10;
        //사망 - 게임매니저로 옮겨도 될수도...?
        if(HP < 0 || HP == 0)
        {
            Debug.Log("!!!!!GameOver!!!!!");
            SceneManager.LoadScene("SampleScene");
            //실패 화면 이나 스테이지 선택 화면으로 이동
        }
    }
    //본인 턴 일때 마나를 하나 얻는다
    public void MyTurn()
    {
        
        AP += 1;
    }
    // 피와 마나를 텍스트에 적는 함수
    public void UpdateState()
    {
        stateText.text = "HP\n" + HP + "\nmana\n" + AP;
    }
    //카드 사용시 마나 소모
    public void ManaConsumption()
    {
        
            AP -= 1;
            UpdateState();

        
        
    }




}
