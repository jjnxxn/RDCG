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
    // 캐릭터 선택창에서 캐릭터 버튼 클릭시 캐릭터선택2 이동
    public void click(){
        SceneManager.LoadScene(2);
    }
}
