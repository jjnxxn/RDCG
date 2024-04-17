using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Selection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // CharacterSelection2에서 스테이지 이동 클릭 시 Stage으로 이동 
    public void StageClickBtn()
    {
        SceneManager.LoadScene("Stage");
    }
    //MainTitle에서 게임시작 버튼 클릭 시 CharacterSelection1으로 이동
    public void MainTitleClickStartBtn(){
        SceneManager.LoadScene("CharacterSelection1");
    }

    // CharacterSelection1화면에서 캐릭터 버튼 클릭시 CharacterSelection2로 이동
    public void CharacterSelection1ClickChar1Btn(){
        SceneManager.LoadScene("CharacterSelection2");
    }

    // CharacterSelection1화면에서 뒤로가기 버튼 클릭시 MainTitle로 이동
     public void CharacterSelection1ClickBackBtn(){
        SceneManager.LoadScene("MainTitle");
    }

    //CharacterSelection2에서 뒤로가기버튼 클릭 시 CharacterSelection1으로 이동
    public void CharacterSelection2ClickBackBtn(){
        SceneManager.LoadScene("CharacterSelection1");
    }

    //게임 클리어 or 게임 오버 화면에서 메인화면 버튼 클릭시 MainTitle로 이동
    public void Ending(){
        SceneManager.LoadScene("MainTitle");
    }
}
