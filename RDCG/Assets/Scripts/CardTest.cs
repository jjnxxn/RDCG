using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


// 카드생성 테스트할려고 만든 스크립트에요 신경 쓰지말고 나중에 삭제예정
public class CardTest : MonoBehaviour
{
    public string targetSceneName = "PlayerCard";

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SceneManager.LoadScene(targetSceneName);
        }
    }
}
