using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KBInput : MonoBehaviour
{

    public string AttackKey;
    public int AttackValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #region
        //if (Input.GetKeyDown(KeyCode.A))  //���̰���
        //{
        //    print("���ڰ�����A");
        //}

        //if (Input.GetKeyUp(KeyCode.A))
        //{
        //    print("���ڵ�����A");
        //}

        //if (Input.GetKey(KeyCode.A))
        //{
        //    print("��һֱ�ڰ�A");
        //}
        #endregion

        if (Input.GetKeyDown(AttackKey))  //���̰���
        {
            print("�㿪ʼ����������������");
            AttackValue += 1;
        }
        
        if (Input.GetKeyUp(AttackKey))
        {
            print("�㷢���˹���");
            print("��ʱ��Ĺ�������" + AttackValue);
        }

        if (Input.GetKey(AttackKey))
        {
            print("��Ĺ�����������");
            if(AttackValue <= 100)
            {
                AttackValue += 1;
            }

        }
    }
}
