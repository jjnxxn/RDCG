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
    //MainTitle에서 게임시작 버튼 클릭 시 CharacterSelection1으로 이동
    public void click(){
        SceneManager.LoadScene("CharacterSelection1");
    }
}
