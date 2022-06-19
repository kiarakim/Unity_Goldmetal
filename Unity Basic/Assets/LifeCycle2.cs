using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle2 : MonoBehaviour
{
    void Update() {
        if (Input.anyKeyDown) // 아무 입력을 최초로 받을 때 true
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");
        //if (Input.anyKey) // 아무 입력을 받으면 true
        //    Debug.Log("플레이어가 아무 키를 누르고 있습니다.");
        

        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("아이템을 구입하였습니다.");
    }
}
