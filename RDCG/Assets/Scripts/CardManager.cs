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
    //ë§ˆìš°ìŠ¤ë¥¼ ì˜¬ë ¸ì„ ë•Œ ì¹´ë“œ ì •ë³´
    public CardInfo selectCard;
    //ë§ˆìš°ìŠ¤ ìœ„ì¹˜ ì •ë³´
    public Vector3 MousePos;

    void Update()
    {
        //ë§ˆìš°ìŠ¤ ìœ„ì¹˜
        MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        MousePos.z = -10;
       
        
    }


    //ì¹´ë“œë¥¼ ê³µê²©í•˜ì§€ ì•Šê³  ë§ˆìš°ìŠ¤ë¥¼ ë•” ë•Œ ë‹¤ì‹œ ì›ëž˜ ìœ„ì¹˜ë¡œ ì´ë™
    void EnlargeCard(bool isEnlarge, CardInfo card)
    {

        //ë§ˆìš°ìŠ¤ë¥¼ ì¹´ë“œ ìœ„ì— ë‘˜ë•Œ ì¹´ë“œì˜ í¬ê¸°ë¥¼ í¬ê²Œ ë§Œë“¬

        if (isEnlarge)
        {
            //í•´ë‹¹ ìœ„ì¹˜ë¡œ ì¹´ë“œ ì´ë™
            Vector3 enlargePos = new Vector3(card.gameObject.transform.position.x, -5f, -18f);
            card.MoveTransform(new PRS(enlargePos, Quaternion.identity, new Vector3(20f, 20f, 20f)), false);
            card.transform.position = enlargePos;


        }
        else

        {

            {//ì•„ë‹ˆë©´ ì›ëž˜ í¬ê¸°ë¡œ ë³€í•¨


                card.MoveTransform(card.originPRS, false);
            }

        }
    }
//ì¹´ë“œ ìœ„ë¡œ ë§ˆìš°ìŠ¤ë¥¼ ë‘˜ë•Œ í•¨ìˆ˜
        public void CardMouseOver(CardInfo card)
        {
            

            
            selectCard = card;

            EnlargeCard(true, selectCard);

        }


    //ë§ˆìš°ìŠ¤ê°€ ì¹´ë“œì—ì„œ ë²—ì–´ë‚  ë•Œ í•¨ìˆ˜
        public void CardMouseExit(CardInfo card)
        {
            

            EnlargeCard(false, selectCard);
        }









    

=======
    //Ä«µå¸¦ »ý¼ºÇÏ±â À§ÇÑ ÇÁ¸®ÆÕ
    public GameObject cardPrefab;
    //Ä«µå¸¦ »ý¼ºÇÒ ½ºÆù Æ÷ÀÎÆ®
   // public Transform cardspawnPoint;
    //µÎ Æ®·£½ºÆûÀº ¾ÆÁ÷ ÇÏ´ÂÁßÀÌ¶ó Áö±ÝÀº ¹«½Ã
    //public Transform myCardLeft;
   // public Transform myCardRight;
    //»ý¼ºµÈ Ä«µå¸¦ µ¦¿¡ ³ÖÀ» ¸®½ºÆ®
    public List<Card1> myCards;
    //playerÀÇ mp°ªÀ» °¡Á®¿À±â À§ÇÑ º¯¼ö
    public GameObject player;
    //Ä«µå¸¦ »ý¼ºÇÒ ÇÁ¸®ÆÕ
    GameObject cardObject;
    //³»°¡ ¼±ÅÃÇÑ Ä«µå Á¤º¸ º¯¼ö
    public Card1 selectCard;
    //Ä«µå¸¦ ¸¶¿ì·Î Å¬¸¯ÇßÀ» ‹š 
    bool isCardDrag;
    //Ä«µå ¿µ¿ª
    bool onCardArea;
    //¸¶¿ì½ºÀÇ À§Ä¡
    public Vector3 MousePos;

    
    //ÇÃ·¹ÀÌ¾îÀÇ ¸¶³ª
    //float myMP;




    /* void Start()
     { //¾×¼Ç ÀÌº¥Æ®·Î onaddcard¿¡ addcardÇÔ¼ö¸¦ µî·Ï
         TurnManager1.OnAddCard += AddCard;

     OriginPos = new Vector3(card.gameObject.transform.position.x, card.gameObject.transform.position.y,
             card.gameObject.transform.position.z);

     }*/

    /*void OnDestroy()
    {//¹Ý´ë·Î »èÁ¦ÇÒ ‹š »ç¿ë ÀÏ´ÜÀº »ç¿ë ¾ÈÇÔ
        TurnManager1.OnAddCard -= AddCard;
    }*/

    void Update()
    {//ÇÃ·¹ÀÌ¾î ¸¶³ª
       // myMP = player.GetComponent<Player1>().playerMP;
        //¸¶¿ì½º À§Ä¡
        MousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        MousePos.z = -10;
        //Ä«µå¿µ¿ª¿¡ ÀÖ´ÂÁö È®ÀÎ
       // DetectCardArea();
        //Ä«µå¸¦ ¸¶¿ì½º·Î Å¬¸¯ ÇßÀ» ¶§ Ä«µå ÀÌµ¿
      /*  if (isCardDrag)
        {
            cardDrag();
        }*/
        
    }

    //Ä«µå ¿µ¿ª¿¡ ¾øÀ» ¶§ Ä«µå ÀÌµ¿
    /*private void cardDrag()
    {//Ä«µå¿µ¿ª¿¡ ¾øÀ¸¸é ¼±ÅÃ Ä«µå¸¦ ¸¶¿ì½º À§Ä¡·Î ÀÌµ¿
        if (!onCardArea)
        {
            selectCard.MoveTransform(new PRS(MousePos, Quaternion.identity, selectCard.originPRS.Scale), false);

        }
    }*/
    //·¹ÀÌÄÉ½ºÆ®¸¦ ½÷¼­ Ä«µå¿µ¿ªÀÎÁö ¾Æ´ÑÁö È®ÀÎ
    /*void DetectCardArea()
    {//·¹ÀÌÄÉ½ºÆ®¸¦ ¹ß»ç
        RaycastHit2D[] hits = Physics2D.RaycastAll(MousePos, Vector3.forward);
        int layer = LayerMask.NameToLayer("cardArea");
        //·¹ÀÌ¸¦ ½÷¼­ ¸ÂÀº ¿ÀºêÁ§Æ®µé Áß Ä«µå¿¡¸®¾îÀÌ¸é Æ®·ç ¾Æ´Ï¸é Æú½º
        onCardArea = Array.Exists(hits, x => x.collider.gameObject.layer == layer);

    }*/

    //Ä«µå»ý¼º ÇÔ¼ö
  /*  void AddCard()
    {//Ä«µå¸¦ ½ºÆù À§Ä¡¿¡ »ý¼º
        cardObject = Instantiate(cardPrefab, cardspawnPoint.position, Quaternion.identity);
        //Card ½ºÅ©¸³Æ®¸¦ °¡Á®¿È
        
        var card = cardObject.GetComponent<Card1>();
        //¸®½ºÆ®¿¡ Ä«µå Á¤º¸ ³Ö±â
        myCards.Add(card);



        cardAlignment();
    }//Ä«µå¸¦ ÇØ´ç À§Ä¡·Î ÀÌµ¿*/

    //Ä«µå¸¦ ³ÂÀ» ¶§ ÇÔ¼ö
   /* void AttackCard()
    {//¸¶¿ì½º Å¬¸¯À» ¶§°í Ä«µå¿µ¿ª ¹ÛÀÏ ¶§ ¼±ÅÃ Ä«µå¸¦ »èÁ¦ÇÏ°í ¸¶³ª¸¦ ÁÙÀÌ°í ´Ù½Ã Ä«µå Á¤·Ä
        if (!isCardDrag && !onCardArea)
        {
            //Ä«µå ¸®½ºÆ®¿¡¼­ ¼±ÅÃ Ä«µå Á¦°Å
            myCards.Remove(selectCard);
            //µÎÆ®À© Á¾·á
            selectCard.transform.DOKill();
            //¼±ÅÃ Ä«µå ÀÌ¸§ µð¹ö±×
            Debug.Log(selectCard.gameObject.GetComponent<CardInfo>().cardName);
            //³» ¸¶³ª ÇØ´ç ÄÚ½ºÆ® ¸¸Å­ »©ÁÜ
            myMP -= selectCard.gameObject.GetComponent<CardInfo>().cardCost;
            //ÇÃ·¹ÀÌ¾î·Î Á¤º¸ Àü´Þ
            player.GetComponent<Player1>().playerMP = myMP;
            //Á¤º¸ ¾÷µ¥ÀÌÆ®
            player.GetComponent<Player1>().UpdateState();

            //°ð¹Ù·Î »èÁ¦ÇÏ±â À§ÇØ
            DestroyImmediate(selectCard.gameObject);
            //»èÁ¦ÇÏ¸é ¹Ì¾ÅÀ¸·Î ³²¾Æ¼­ ¿À·ù°¡ ³ª±â ¶«¿¡
            selectCard = null;
            //Ä«µå Á¤·Ä
            cardAlignment();

        }
        
    }*/

  /*  void cardAlignment()
    {//Ä«µåµéÀÇ À§Ä¡Á¤º¸
        List<PRS> originCardPRSs = new List<PRS>();

        originCardPRSs = RoundAlignment(myCardLeft, myCardRight, myCards.Count, -0.5f, new Vector3(5f, 10f, 5f));


        //Ä«µå ¸®½ºÆ® ¼ö ¸¸Å­ ¹Ýº¹
        for (int i = 0; i < myCards.Count; i++)
        {//ÇØ´ç Ä«µå¸¦ ÁöÁ¤ À§Ä¡·Î ÀÌµ¿
            var card = myCards[i];

            card.originPRS = originCardPRSs[i];
            card.MoveTransform(card.originPRS, true, 0.7f);
        }
    }*/
    //Ä«µåÀÇ À§Ä¡ º¯°æÇÏ´Â ÇÔ¼ö
   /* List<PRS> RoundAlignment(Transform left, Transform right, int count, float height, Vector3 scale)
    {//Ä«µå°¡ ¸î°³ÀÎÁö¸¦ À§ÇÑ º¯¼ö
        float[] objectLerps = new float[count];
        //Ä«µå °¹¼ö ¸¸Å­ ¸®½ºÆ® °ø°£ È®º¸
        List<PRS> results = new List<PRS>(count);
        //Ä«µå°¡ 3°³ ±îÁö´Â ÁöÁ¤ÇÑ À§Ä¡·Î ÀÌµ¿ 4°³ ÀÌ»óÀ¸·Î´Â °¹¼ö¿¡ µû¶ó °£°Ý º¯°æ
        switch (count)
        {
            case 1: objectLerps = new float[] { 0.5f }; break;
            case 2: objectLerps = new float[] { 0.27f, 0.73f }; break;
            case 3: objectLerps = new float[] { 0.1f, 0.5f, 0.9f }; break;
            default:
                //Ä«µå À§Ä¡¸¦ À§ÇØ À§Ä¡ ³ª´©±â
                float interval = 1f / (count - 1);
                //Ä«µå À§Ä¡¸¦ ¹è¿­¿¡ ÀúÀå
                for (int i = 0; i < count; i++)
                {
                    objectLerps[i] = interval * i;

                }

                break;

        }
        
        for (int i = 0; i < count; i++)
        {//Á¤ÇÑ À§Ä¡·Î À§Ä¡ ÀúÀå
            var myPos = Vector3.Lerp(left.position, right.position, objectLerps[i]);
            var myRot = Quaternion.identity;

            //ÇØ´ç À§Ä¡·Î ÀÌµ¿
            results.Add(new PRS(myPos, myRot, scale));
        }

        return results;
    }*/
    //Ä«µå¸¦ °ø°ÝÇÏÁö ¾Ê°í ¸¶¿ì½º¸¦ ¶ª ¶§ ´Ù½Ã ¿ø·¡ À§Ä¡·Î ÀÌµ¿
    void EnlargeCard(bool isEnlarge,  Card1 card)
    {
        
        //¸¶¿ì½º¸¦ Ä«µå À§¿¡ µÑ¶§ Ä«µåÀÇ Å©±â¸¦ Å©°Ô ¸¸µë
        if (isEnlarge)
        {
            
            Vector3 enlargePos = new Vector3(card.gameObject.transform.position.x, -5f, -18f);
            card.MoveTransform(new PRS(enlargePos, Quaternion.identity, new Vector3(20f, 20f, 20f)), false);
            card.transform.position = enlargePos;
             

        }
        else
        {//¾Æ´Ï¸é ¿ø·¡ Å©±â·Î º¯ÇÔ
            
            card.MoveTransform(card.originPRS, false);
        }

    }
    //Ä«µå À§·Î ¸¶¿ì½º¸¦ µÑ¶§
    public void CardMouseOver(Card1 card)
    {
        
        selectCard = card;

        EnlargeCard(true, selectCard);

        }
    



    //Ä«µå¿¡¼­ ¸¶¿ì½º¸¦ –E ¶§
    public void CardMouseExit(Card1 card)
    {
        Debug.Log("Exit");
        //Ä«µå Å©±â¸¦ ¿ø·¡´ë·Î
        EnlargeCard(false, selectCard);
    }
    //¸¶¿ì½º¸¦ ´©¸¦ ¶§
    public void CardMouseDown()
    {//µå·¡±× ÇÒ¼ö ÀÖ°Ô ÇÏ´Â ºÒ ÇÔ¼ö Æ®·ç·Î
        isCardDrag = true;
        
    }
    //¾Æ´Ò ¶§
   /* public void CardMouseUP()
    {//µå·¡±× ÇÒ¼ö ÀÖ°Ô ÇÏ´Â ºÒ ÇÔ¼ö Æú½º·Î
       // isCardDrag= false;
        //ÇöÀç ¸¶³ª°¡ Ä«µå ÄÚ½ºÆ® º¸´Ù ¸¹À» ¶§¸¸ Ä«µå°¡ »ç¶óÁü
        if (myMP >= selectCard.gameObject.GetComponent<CardInfo>().cardCost) 
        { 
            AttackCard();

        }
        


    }*/

>>>>>>> 23e66567c4bb5c5ec3c7ba1e9cb57fd66ef84709
}


