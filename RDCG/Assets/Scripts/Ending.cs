using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ending : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //게임 클리어 or 게임 오버 화면에서 메인화면 버튼 클릭시 MainTitle로 이동
    public void click(){
        SceneManager.LoadScene("MainTitle");
    }
}
