using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeCycle : MonoBehaviour
{
    void Awake() //초기화. 최초 1회실행
    {
        Debug.Log("플레이어 데이터가 준비되었습니다.");
    }

    void OnEnable() // 게임 오브젝트가 활성화 되었을 때. 최초 1회실행이 아니라 끄고끄고할때마다 실행됨
    {
        Debug.Log("플레이어가 로그인 했습니다.");
    }

    void start() //초기화. 최초 1회실행
    {
        Debug.Log("사냥 장비를 챙겼습니다.");
    }
    // * 활성화는 초기화와 물리 사이에 있음.
    void FixedUpdate() //물리 연산 업데이트. 고정된 실행 주기로 CPU부하가 많다.
    {
        Debug.Log("이동~");
    }

    void Update() //게임 로직 업데이트. 주기적으로 변하는 로직 사용할때
    {
        Debug.Log("몬스터 사냥!!");
    }

    void LateUpdate() //모든 업데이트 끝난 후. 로직의 후처리
    {
        Debug.Log("경험치 획득");
    }

    void OnDisable() // 게임 오브젝트가 비활성화 되었을 때. 모든 업데이트가 끝나면 실행
    {
        Debug.Log("플레이어가 로그아웃했습니다.");
    }

    void OnDestroy() //게임 오브젝트가 삭제될 때
    {
        Debug.Log("플레이어 데이터를 해체하였습니다.");
        Debug.Log("한글이 깨지네");
    }
}
