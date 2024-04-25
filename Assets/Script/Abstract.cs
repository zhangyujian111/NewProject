using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class MyClass5
{
    public MyClass5()
    {
        Debug.Log("MyClass5 ��ͨ����������");
    }
    static MyClass5()
    {
        Debug.Log("MyClass5 ��̬����������");
    }

    public void show1()
    {
        Debug.Log("show1��ִ��");
    }
    public virtual void show2()
    {
        Debug.Log("MyClass5 show2��ִ��");
    }

    public abstract void show3();  //������������{}�ṹ��
}
public class MyClass6 : MyClass5
{
    public MyClass6()
    {
        Debug.Log("MyClass6 ��ͨ����������");
    }

    public override void show2()
    {
        Debug.Log("MyClass6 show2 ��ִ��");
    }

    public override void show3()  //�����еĳ����������������д
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
