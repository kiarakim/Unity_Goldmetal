using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle2 : MonoBehaviour
{

    private void Start()
    {
        //Vector3 vec = new Vector3(0, 0, 0); //x축, y축, z축의 크기. 즉, 방향과 크기를 모두 갖고 있기 때문에 벡터값이라고 함

        //Translate : 벡터 값을 현재 위치에 더하는 함수
        //transform.Translate(vec);
        //int number = 4; //스칼라 : 수순한 값
        



    }
    void Update() {

        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal"), 
            Input.GetAxisRaw("Vertical"), 
            0);
        transform.Translate(vec);

        /*
        if (Input.anyKeyDown) // 아무 입력을 최초로 받을 때 true
            Debug.Log("플레이어가 아무 키를 눌렀습니다.");
        //if (Input.anyKey) // 아무 입력을 받으면 true
        //    Debug.Log("플레이어가 아무 키를 누르고 있습니다.");
        */

        //키보드 버튼 입력을 받으면 true
        /*
        if (Input.GetKeyDown(KeyCode.Return))
            Debug.Log("아이템을 구입하였습니다.");
        if (Input.GetKey(KeyCode.LeftArrow)) 
            Debug.Log("왼쪽으로 이동 중");
        if (Input.GetKeyUp(KeyCode.RightArrow))
            Debug.Log("오른쪽 이동을 멈추었습니다.");
        */


        //마우스 버튼 입력 받으면 true
        /*
        if (Input.GetMouseButtonDown(0))
            Debug.Log("미사일 발사!");
        if (Input.GetMouseButton(0))
            Debug.Log("미사일 모으는 중....");
        if (Input.GetMouseButtonUp(0))
            Debug.Log("슈퍼 미사일 발사!!");
        */


        //GetButton : Input 버튼 입력 받으면 true
        /*
        if (Input.GetButtonDown("Jump"))
            Debug.Log("점프!"); //얘는 잘 안쓰지. 
        if (Input.GetButton("Jump"))
            Debug.Log("점프 모으는 중...");
        if (Input.GetButtonUp("Jump"))
            Debug.Log("슈퍼 점프!!");
        */

        /*
        if (Input.GetButton("Horizontal"))
        {
            Debug.Log("횡 이동 중..." 
                + Input.GetAxisRaw("Horizontal"));
             //GetAxis : 수평, 수직 버튼 입력 받으면 float
        }
        if (Input.GetButton("Vertical"))
        {
            Debug.Log("종 이동 중..."
                + Input.GetAxisRaw("Vertical"));
        }
        */

    }
}
