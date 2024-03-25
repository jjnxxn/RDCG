using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //게임 오버화면에서 메인메뉴 버튼 클릭시 메인메뉴 이동
    public void click(){
        SceneManager.LoadScene(0);
    }
}
