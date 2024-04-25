using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MyClass  //类的初始化
{
    public int a = 100;  //普通成员变量
    public void Func1()  //普通函数
    {
        Debug.Log("Func1被调用");
    }
    //如果变量或者函数加 static 则被标记为静态变量或静态函数，不能在外部通过该类的对象被访问到，
    //只能通过该类的名字被访问

    public static int aa = 111;
    public static void Func2()
    {
        Debug.Log("Func2被调用");
    }
}
public class NewScript6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MyClass myClass = new MyClass();  // 类的实例化/初始化
        int b = myClass.a;
        Debug.Log(b);
        myClass.Func1();

        //静态对象访问
        int bb = MyClass.aa;  //静态对象或函数不能通过类的实例对象访问
        Debug.Log(bb);        //只能通过该类名直接访问
        MyClass.Func2();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
