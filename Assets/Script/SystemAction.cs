using System;  //要使用这个System命名空间
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemAction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Action action1 = show1;
        action1();
        Action<int, int> action2 = show2;
        action2(1,2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void show1()
    {
        Debug.Log("show1被调用");
    }
    void show2(int a , int b)
    {
        Debug.Log("action:" + (a + b));
    }
}
