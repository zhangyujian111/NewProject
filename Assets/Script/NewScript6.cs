using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MyClass  //��ĳ�ʼ��
{
    public int a = 100;  //��ͨ��Ա����
    public void Func1()  //��ͨ����
    {
        Debug.Log("Func1������");
    }
    //����������ߺ����� static �򱻱��Ϊ��̬������̬�������������ⲿͨ������Ķ��󱻷��ʵ���
    //ֻ��ͨ����������ֱ�����

    public static int aa = 111;
    public static void Func2()
    {
        Debug.Log("Func2������");
    }
}
public class NewScript6 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        MyClass myClass = new MyClass();  // ���ʵ����/��ʼ��
        int b = myClass.a;
        Debug.Log(b);
        myClass.Func1();

        //��̬�������
        int bb = MyClass.aa;  //��̬�����������ͨ�����ʵ���������
        Debug.Log(bb);        //ֻ��ͨ��������ֱ�ӷ���
        MyClass.Func2();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}
