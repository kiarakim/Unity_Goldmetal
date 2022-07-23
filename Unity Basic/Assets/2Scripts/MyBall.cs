using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBall : MonoBehaviour
{
    Rigidbody rigid;
    void Start()
    {

        rigid = GetComponent<Rigidbody>();
        /*rigid.velocity = Vector3.right;//������ �ӷ�*/
        /*rigid.velocity = new Vector3(2, 4, 3);//���� �� Ƣ�� ������*/
        

    }

    void FixedUpdate()
    {
        /*rigid.velocity= Vector3.forward;//1.�ӷ� �ٲٱ�*/
        if (Input.GetButtonDown("Jump"))
        {
            rigid.AddForce(Vector3.up * 50, ForceMode.Impulse);//ĳ���Ͱ� ������ �� ��
        }

        //2. ������ �б�
        Vector3 vec = new Vector3(
            Input.GetAxisRaw("Horizontal"), //x��(���� ������)    
            0,                              //y��(����)
            Input.GetAxisRaw("Vertical"));  //z��(�� ��)

        rigid.AddForce(vec, ForceMode.Impulse);//ĳ���Ͱ� ������ �� ��

        //3. ȸ����
        /*rigid.AddTorque(Vector3.back);*/

    }

    private void OnTriggerStay(Collider other) //��Cube�� Is Trigger üũ�ؾ���
    {
        if (other.name == "Cube")
            rigid.AddForce(Vector3.up * 2, ForceMode.Impulse);
    }

    public void Jump()
    {
        rigid.AddForce(Vector3.up * 20, ForceMode.Impulse);
    }
}
