using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo1 : MonoBehaviour
{

    private void OnCollisionExit2D(Collision2D collision)  //��ײ����ʱ
    {
        print("��ײ������");
    }
    private void OnCollisionEnter2D(Collision2D collision)  //��ײʱ
    {
        print("��ײ��" + "����������" + collision.gameObject.name);
    }
    private void OnCollisionStay2D(Collision2D collision)  //��ײ������
    {
        print("����ײing");
    }
}
