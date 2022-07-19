using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;
    void Start()
    {

        rigid = GetComponent<Rigidbody>();
        /*rigid.velocity = Vector3.right;//오른쪽 속력*/
        /*rigid.velocity = new Vector3(2, 4, 3);//위로 통 튀듯 움직임*/
        

    }

    void FixedUpdate()
    {
        /*rigid.velocity= Vector3.forward;//1.속력 바꾸기*/
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);//캐릭터가 점프할 때 씀
        }

        //2. 힘으로 밀기
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal"), //x축(왼쪽 오른쪽)    
            0,                              //y축(높이)
            Input.GetAxisRaw("Vertical"));  //z축(앞 뒤)

        rigid.AddForce(vec, ForceMode.Impulse);//캐릭터가 점프할 때 씀

        //3. 회전력
        /*rigid.AddTorque(Vector3.back);*/

    }

    private void OnTriggerStay(Collider other) //꼭Cube에 Is Trigger 체크해야함
    {
        if (other.name == "Cube")
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
    }

    public void Jump()
    {
        rigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }
}
