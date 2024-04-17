using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoldText : MonoBehaviour
{
    public Text gainGoldText; // 획득한 골드를 텍스트로 표기

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gainGoldText.text = "획득 골드 + " + Player.playerGainGold.ToString(); // 획득한 골드를 텍스트를 실시간으로 변경
    }
}
