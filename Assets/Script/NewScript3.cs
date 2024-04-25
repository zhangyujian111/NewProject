using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewScript3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        showContxt();
        showName("老王");
        int result = getValue(2, 4);
        Debug.Log(result);
    }

    //无返回值无参函数
    void showContxt()
    {
        Debug.Log("showContxt被调用");
    }

    //无返回值有参函数
    void showName(string name)
    {
        Debug.Log("showName输出参数:" + name);
    }

    //有返回值函数
    int getValue(int a, int b)
    {
        int sum = a + b;
        return sum;
    }



}
