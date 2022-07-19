using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtherBall : MonoBehaviour
{
    //������ ���� �ϰ� �ٲܰ���
    MeshRenderer mesh;
    Material mat;
    void Start()
    {
        mesh = GetComponent<MeshRenderer>();
        mat = mesh.material;//MeshRenderer�� Material ��������
    }

    private void OnCollisionEnter(Collision collision)//�浹���� ��
    {
        if(collision.gameObject.name == "myBall") //�̰� ���ϸ� �ٴ��̶� �پ��־ ������� ���ϴµ� �̷��� �ϸ� myBall ������ ���� �ٲ�
            mat.color = new Color(0, 0, 0);
    }

    private void OnCollisionExit(Collision collision)//�浹���� ��
    {
        if (collision.gameObject.name == "myBall") //�̰� ���ϸ� �ٴ��̶� �پ��־ ������� ���ϴµ� �̷��� �ϸ� myBall ������ ���� �ٲ�
            mat.color = new Color(1, 1, 1);
    }
}
