using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invoke : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //  Invoke("Demo1", 2);  //输入方法名和时间，表明在2秒后执行一次Demo1
        InvokeRepeating("Demo1", 1, 2);  //输入方法名，时间和间隔时间，表面在1秒后执行Demo1，并且每2秒重复执行一次
        CancelInvoke("Demo1");  //取消调用Demo1
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
