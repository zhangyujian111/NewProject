using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MBInput : MonoBehaviour
{


    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0)){
            print("����������");
            print(Input.mousePosition);  //��ʾ��������
        }

        if (Input.GetMouseButtonUp(0))
        {
            print("����������");
        }

        if (Input.GetMouseButton(0))
        {
            print("��������������");
        }
    }
}
