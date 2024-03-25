using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelection1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    // CharacterSelection1화면에서 캐릭터 버튼 클릭시 CharacterSelection2로 이동
    public void click(){
        SceneManager.LoadScene("CharacterSelection2");
    }
    // CharacterSelection1화면에서 뒤로가기 버튼 클릭시 MainTitle로 이동
     public void click2(){
        SceneManager.LoadScene("MainTitle");
    }
}
