using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 target = new Vector3(8, 1.5f, 0);
    
    void Update()
    {
        //1. MoveTowards : ��� �̵�. �Ű� ������ (���� ��ġ, ��ǥ��ġ, �ӵ�)�� ����. ������ �Ű������� ����Ͽ� �ӵ� ����
        /*
        transform.position =
            Vector3.MoveTowards(transform.position, target, 1f);
        */

        //2. SmoothDamp : �ε巯�� ���� �̵� (���� ��ġ, ��ǥ ��ġ, ���� �ӵ�, �ӵ�). ������ �Ű������� �ݺ���Ͽ� �ӵ� ����
        /*
        Vector3 velo = Vector3.zero;

        transform.position =
            Vector3.SmoothDamp(transform.position, target, ref velo, 0.1f);
        //ref : ���� ���� -> �ǽð����� �ٲ�� �� ���� ����
        */

        // 3. Lerp : ���� ����, SmoothDamp���� ���� �ð��� ��.  ������ �Ű������� ����Ͽ� �ӵ� ����(�ִ� 1)
        /*
        transform.position =
            Vector3.Lerp(transform.position, target, 0.05f);
        */

        // 4. Slerp : ���� ���� ����, ȣ�� �׸��� �̵�
        transform.position =
            Vector3.Slerp(transform.position, target, 0.05f);
    }

 
}
