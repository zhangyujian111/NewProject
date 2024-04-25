using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace MySpace  //命名空间，可以在这个空间里创造与外界同名的类
{
    public class MyClass
    {
        public int a;
        public  MyClass()  //构造函数，与类同名
        {
            Debug.Log("MySpace下的MyClass类中的构造函数被调用");  //在类对象实例化时输出
        }

        ~MyClass()  //析构函数，与类同名，前加~且不能加其他前缀
        {
            Debug.Log("MySpace下的MyClass类中的析构函数被调用");   //在类对象被删除时输出

        }
        public void Func1()
        {
            Debug.Log("111");
        }
    }

}
public class NewScript8 : MonoBehaviour
{
    MySpace.MyClass myClass;  //命名空间下的类要以该命名空间为前缀



    // Start is called before the first frame update
    void Start()
    {
        myClass = new MySpace.MyClass();  //在Start中实例化
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))  //监听鼠标事件，当鼠标左键按下时，执行以下操作。
                                         //鼠标左键 0 鼠标右键 1 鼠标滑轮 2
        {
            Destroy(this.gameObject);   //删除当前的游戏对象
                                        //删除当前对象后，该对象下的实例也会被删除，从而触发析构函数
        }
    }
}
