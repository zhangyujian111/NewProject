using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delegate : MonoBehaviour
{

    public delegate void BaseDelegate();  //定义一个委托，有点类似方法
    //其他的，包括带参、有返回值和泛型等等形式差不多
    // Start is called before the first frame update
    void Start()
    {
        BaseDelegate Show = show1;  //将一个方法交给委托对象
        Show();   //直接调用，类似于函数
        Show.Invoke();   //与上作用相同
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void show1()   //定义一个方法
    {
        Debug.Log("show1被调用");
    }
}
