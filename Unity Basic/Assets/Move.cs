using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);
    
    void Update()
    {
        //1. MoveTowards : 등속 이동. 매개 변수는 (현재 위치, 목표위치, 속도)로 구성. 마지막 매개변수에 비례하여 속도 증가
        /*
        transform.position =
            Vector3.MoveTowards(transform.position, target, 1f);
        */

        //2. SmoothDamp : 부드러운 감속 이동 (현재 위치, 목표 위치, 참소 속도, 속도). 마지막 매개변수에 반비례하여 속도 증가
        /*
        Vector3 velo = Vector3.zero;

        transform.position =
            Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);
        //ref : 참조 접근 -> 실시간으로 바뀌는 값 적용 가능
        */

        // 3. Lerp : 선형 보간, SmoothDamp보다 감속 시간이 김.  마지막 매개변수에 비례하여 속도 증가(최대 1)
        /*
        transform.position =
            Vector3.Lerp(transform.position, target, 0.05f);
        */

        // 4. Slerp : 구면 선형 보간, 호를 그리며 이동
        transform.position =
            Vector3.Slerp(transform.position, target, 0.05f);
    }

 
}
