using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)  //��������
    {
        if(collision.gameObject.tag == "fair")
        {
            print("������˻���");
        }
    }

    private void OnTriggerStay2D(Collider2D collision)  //������
    {
        if (collision.gameObject.tag == "fair")
        {
            print("��һֱ�ڻ���");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)  //�����˳�
    {
        if (collision.gameObject.tag == "fair")
        {
            print("���뿪�˻�");
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floar")
        {
            print("����䵽������");
        }
    }

}
