using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace MySpace  //�����ռ䣬����������ռ��ﴴ�������ͬ������
{
    public class MyClass
    {
        public int a;
        public  MyClass()  //���캯��������ͬ��
        {
            Debug.Log("MySpace�µ�MyClass���еĹ��캯��������");  //�������ʵ����ʱ���
        }

        ~MyClass()  //��������������ͬ����ǰ��~�Ҳ��ܼ�����ǰ׺
        {
            Debug.Log("MySpace�µ�MyClass���е���������������");   //�������ɾ��ʱ���

        }
        public void Func1()
        {
            Debug.Log("111");
        }
    }

}
public class NewScript8 : MonoBehaviour
{
    MySpace.MyClass myClass;  //�����ռ��µ���Ҫ�Ը������ռ�Ϊǰ׺



    // Start is called before the first frame update
    void Start()
    {
        myClass = new MySpace.MyClass();  //��Start��ʵ����
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))  //��������¼���������������ʱ��ִ�����²�����
                                         //������ 0 ����Ҽ� 1 ��껬�� 2
        {
            Destroy(this.gameObject);   //ɾ����ǰ����Ϸ����
                                        //ɾ����ǰ����󣬸ö����µ�ʵ��Ҳ�ᱻɾ�����Ӷ�������������
        }
    }
}
