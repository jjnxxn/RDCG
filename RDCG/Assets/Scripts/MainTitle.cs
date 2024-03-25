using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainTitle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //메인화면에서 게임시작 버튼 클릭 시 캐릭터 선택창으로 이동
    public void click(){
        SceneManager.LoadScene(1);
    }
}
