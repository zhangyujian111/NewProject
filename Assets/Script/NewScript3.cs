using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScript3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        showContxt();
        showName("����");
        int result = getValue(2, 4);
        Debug.Log(result);
    }

    //�޷���ֵ�޲κ���
    void showContxt()
    {
        Debug.Log("showContxt������");
    }

    //�޷���ֵ�вκ���
    void showName(string name)
    {
        Debug.Log("showName�������:" + name);
    }

    //�з���ֵ����
    int getValue(int a, int b)
    {
        int sum = a + b;
        return sum;
    }



}
