using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //  Invoke("Demo1", 2);  //���뷽������ʱ�䣬������2���ִ��һ��Demo1
        InvokeRepeating("Demo1", 1, 2);  //���뷽������ʱ��ͼ��ʱ�䣬������1���ִ��Demo1������ÿ2���ظ�ִ��һ��
        CancelInvoke("Demo1");  //ȡ������Demo1
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Demo1()
    {
        print("Demo1");
    }
}
