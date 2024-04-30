using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Diagnostics;
using DG.Tweening;
using Unity.VisualScripting;
using UnityEngine.Assertions.Must;

public class CardManager : MonoBehaviour
{
    public static CardManager Inst { get; private set; }

    void Awake() => Inst = this;

<<<<<<< HEAD
<<<<<<< HEAD
    //마우스를 올렸을 때 카드 정보
    public CardInfo selectCard;
    //마우스 위치 정보
    public Vector3 MousePos;

    void Update()
    {
        //마우스 위치
        MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        MousePos.z = -10;
       
        
    }


    //카드를 공격하지 않고 마우스를 땔 때 다시 원래 위치로 이동
    void EnlargeCard(bool isEnlarge, CardInfo card)
    {

        //마우스를 카드 위에 둘때 카드의 크기를 크게 만듬

        if (isEnlarge)
        {
            //해당 위치로 카드 이동
            Vector3 enlargePos = new Vector3(card.gameObject.transform.position.x, -5f, -18f);
            card.MoveTransform(new PRS(enlargePos, Quaternion.identity, new Vector3(20f, 20f, 20f)), false);
            card.transform.position = enlargePos;


        }
        else

        {

            {//아니면 원래 크기로 변함


                card.MoveTransform(card.originPRS, false);
            }

        }
    }
//카드 위로 마우스를 둘때 함수
        public void CardMouseOver(CardInfo card)
        {
            

            
            selectCard = card;

            EnlargeCard(true, selectCard);

        }


    //마우스가 카드에서 벗어날 때 함수
        public void CardMouseExit(CardInfo card)
        {
            

            EnlargeCard(false, selectCard);
        }









    

=======
=======
>>>>>>> 23e66567c4bb5c5ec3c7ba1e9cb57fd66ef84709
    //ī�带 �����ϱ� ���� ������
    public GameObject cardPrefab;
    //ī�带 ������ ���� ����Ʈ
   // public Transform cardspawnPoint;
    //�� Ʈ�������� ���� �ϴ����̶� ������ ����
    //public Transform myCardLeft;
   // public Transform myCardRight;
    //������ ī�带 ���� ���� ����Ʈ
    public List<Card1> myCards;
    //player�� mp���� �������� ���� ����
    public GameObject player;
    //ī�带 ������ ������
    GameObject cardObject;
    //���� ������ ī�� ���� ����
    public Card1 selectCard;
    //ī�带 ����� Ŭ������ �� 
    bool isCardDrag;
    //ī�� ����
    bool onCardArea;
    //���콺�� ��ġ
    public Vector3 MousePos;

    
    //�÷��̾��� ����
    //float myMP;




    /* void Start()
     { //�׼� �̺�Ʈ�� onaddcard�� addcard�Լ��� ���
         TurnManager1.OnAddCard += AddCard;

     OriginPos = new Vector3(card.gameObject.transform.position.x, card.gameObject.transform.position.y,
             card.gameObject.transform.position.z);

     }*/

    /*void OnDestroy()
    {//�ݴ�� ������ �� ��� �ϴ��� ��� ����
        TurnManager1.OnAddCard -= AddCard;
    }*/

    void Update()
    {//�÷��̾� ����
       // myMP = player.GetComponent<Player1>().playerMP;
        //���콺 ��ġ
        MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        MousePos.z = -10;
        //ī�念���� �ִ��� Ȯ��
       // DetectCardArea();
        //ī�带 ���콺�� Ŭ�� ���� �� ī�� �̵�
      /*  if (isCardDrag)
        {
            cardDrag();
        }*/
        
    }

    //ī�� ������ ���� �� ī�� �̵�
    /*private void cardDrag()
    {//ī�念���� ������ ���� ī�带 ���콺 ��ġ�� �̵�
        if (!onCardArea)
        {
            selectCard.MoveTransform(new PRS(MousePos, Quaternion.identity, selectCard.originPRS.Scale), false);

        }
    }*/
    //�����ɽ�Ʈ�� ���� ī�念������ �ƴ��� Ȯ��
    /*void DetectCardArea()
    {//�����ɽ�Ʈ�� �߻�
        RaycastHit2D[] hits = Physics2D.RaycastAll(MousePos, Vector3.forward);
        int layer = LayerMask.NameToLayer("cardArea");
        //���̸� ���� ���� ������Ʈ�� �� ī�忡�����̸� Ʈ�� �ƴϸ� ����
        onCardArea = Array.Exists(hits, x => x.collider.gameObject.layer == layer);

    }*/

    //ī����� �Լ�
  /*  void AddCard()
    {//ī�带 ���� ��ġ�� ����
        cardObject = Instantiate(cardPrefab, cardspawnPoint.position, Quaternion.identity);
        //Card ��ũ��Ʈ�� ������
        
        var card = cardObject.GetComponent<Card1>();
        //����Ʈ�� ī�� ���� �ֱ�
        myCards.Add(card);



        cardAlignment();
    }//ī�带 �ش� ��ġ�� �̵�*/

    //ī�带 ���� �� �Լ�
   /* void AttackCard()
    {//���콺 Ŭ���� ���� ī�念�� ���� �� ���� ī�带 �����ϰ� ������ ���̰� �ٽ� ī�� ����
        if (!isCardDrag && !onCardArea)
        {
            //ī�� ����Ʈ���� ���� ī�� ����
            myCards.Remove(selectCard);
            //��Ʈ�� ����
            selectCard.transform.DOKill();
            //���� ī�� �̸� �����
            Debug.Log(selectCard.gameObject.GetComponent<CardInfo>().cardName);
            //�� ���� �ش� �ڽ�Ʈ ��ŭ ����
            myMP -= selectCard.gameObject.GetComponent<CardInfo>().cardCost;
            //�÷��̾�� ���� ����
            player.GetComponent<Player1>().playerMP = myMP;
            //���� ������Ʈ
            player.GetComponent<Player1>().UpdateState();

            //��ٷ� �����ϱ� ����
            DestroyImmediate(selectCard.gameObject);
            //�����ϸ� �̾����� ���Ƽ� ������ ���� ����
            selectCard = null;
            //ī�� ����
            cardAlignment();

        }
        
    }*/

  /*  void cardAlignment()
    {//ī����� ��ġ����
        List<PRS> originCardPRSs = new List<PRS>();

        originCardPRSs = RoundAlignment(myCardLeft, myCardRight, myCards.Count, -0.5f, new Vector3(5f, 10f, 5f));


        //ī�� ����Ʈ �� ��ŭ �ݺ�
        for (int i = 0; i < myCards.Count; i++)
        {//�ش� ī�带 ���� ��ġ�� �̵�
            var card = myCards[i];

            card.originPRS = originCardPRSs[i];
            card.MoveTransform(card.originPRS, true, 0.7f);
        }
    }*/
    //ī���� ��ġ �����ϴ� �Լ�
   /* List<PRS> RoundAlignment(Transform left, Transform right, int count, float height, Vector3 scale)
    {//ī�尡 ������� ���� ����
        float[] objectLerps = new float[count];
        //ī�� ���� ��ŭ ����Ʈ ���� Ȯ��
        List<PRS> results = new List<PRS>(count);
        //ī�尡 3�� ������ ������ ��ġ�� �̵� 4�� �̻����δ� ������ ���� ���� ����
        switch (count)
        {
            case 1: objectLerps = new float[] { 0.5f }; break;
            case 2: objectLerps = new float[] { 0.27f, 0.73f }; break;
            case 3: objectLerps = new float[] { 0.1f, 0.5f, 0.9f }; break;
            default:
                //ī�� ��ġ�� ���� ��ġ ������
                float interval = 1f / (count - 1);
                //ī�� ��ġ�� �迭�� ����
                for (int i = 0; i < count; i++)
                {
                    objectLerps[i] = interval * i;

                }

                break;

        }
        
        for (int i = 0; i < count; i++)
        {//���� ��ġ�� ��ġ ����
            var myPos = Vector3.Lerp(left.position, right.position, objectLerps[i]);
            var myRot = Quaternion.identity;

            //�ش� ��ġ�� �̵�
            results.Add(new PRS(myPos, myRot, scale));
        }

        return results;
    }*/
    //ī�带 �������� �ʰ� ���콺�� �� �� �ٽ� ���� ��ġ�� �̵�
    void EnlargeCard(bool isEnlarge,  Card1 card)
    {
        
        //���콺�� ī�� ���� �Ѷ� ī���� ũ�⸦ ũ�� ����
        if (isEnlarge)
        {
            
            Vector3 enlargePos = new Vector3(card.gameObject.transform.position.x, -5f, -18f);
            card.MoveTransform(new PRS(enlargePos, Quaternion.identity, new Vector3(20f, 20f, 20f)), false);
            card.transform.position = enlargePos;
             

        }
        else
        {//�ƴϸ� ���� ũ��� ����
            
            card.MoveTransform(card.originPRS, false);
        }

    }
    //ī�� ���� ���콺�� �Ѷ�
    public void CardMouseOver(Card1 card)
    {
        
        selectCard = card;

        EnlargeCard(true, selectCard);

        }
    



    //ī�忡�� ���콺�� �E ��
    public void CardMouseExit(Card1 card)
    {
        Debug.Log("Exit");
        //ī�� ũ�⸦ �������
        EnlargeCard(false, selectCard);
    }
    //���콺�� ���� ��
    public void CardMouseDown()
    {//�巡�� �Ҽ� �ְ� �ϴ� �� �Լ� Ʈ���
        isCardDrag = true;
        
    }
    //�ƴ� ��
   /* public void CardMouseUP()
    {//�巡�� �Ҽ� �ְ� �ϴ� �� �Լ� ������
       // isCardDrag= false;
        //���� ������ ī�� �ڽ�Ʈ ���� ���� ���� ī�尡 �����
        if (myMP >= selectCard.gameObject.GetComponent<CardInfo>().cardCost) 
        { 
            AttackCard();

        }
        


    }*/

<<<<<<< HEAD
>>>>>>> 23e66567c4bb5c5ec3c7ba1e9cb57fd66ef84709
=======
>>>>>>> 23e66567c4bb5c5ec3c7ba1e9cb57fd66ef84709
}


