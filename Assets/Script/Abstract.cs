using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class MyClass5
{
    public MyClass5()
    {
        Debug.Log("MyClass5 普通函数被调用");
    }
    static MyClass5()
    {
        Debug.Log("MyClass5 静态函数被调用");
    }

    public void show1()
    {
        Debug.Log("show1被执行");
    }
    public virtual void show2()
    {
        Debug.Log("MyClass5 show2被执行");
    }

    public abstract void show3();  //抽象函数不能有{}结构体
}
public class MyClass6 : MyClass5
{
    public MyClass6()
    {
        Debug.Log("MyClass6 普通函数被调用");
    }

    public override void show2()
    {
        Debug.Log("MyClass6 show2 被执行");
    }

    public override void show3()  //父类中的抽象函数，子类必须重写
    {
        
    }
}



public class Abstract : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MyClass6 myClass6 = new MyClass6();
        myClass6.show1();
        myClass6.show2();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
