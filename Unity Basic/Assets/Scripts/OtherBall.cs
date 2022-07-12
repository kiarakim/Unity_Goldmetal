using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
    //공들의 색을 일괄 바꿀거임
    MeshRenderer mesh;
    Material mat;
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;//MeshRenderer의 Material 가져오기
    }

    private void OnCollisionEnter(Collision collision)//충돌했을 때
    {
        if(collision.gameObject.name == "myBall") //이거 안하면 바닥이랑 붙어있어서 실행즉시 변하는데 이렇게 하면 myBall 만났을 때만 바뀜
            mat.color = new Color(0, 0, 0);
    }

    private void OnCollisionExit(Collision collision)//충돌했을 때
    {
        if (collision.gameObject.name == "myBall") //이거 안하면 바닥이랑 붙어있어서 실행즉시 변하는데 이렇게 하면 myBall 만났을 때만 바뀜
            mat.color = new Color(1, 1, 1);
    }
}
